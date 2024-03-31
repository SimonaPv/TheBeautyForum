using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Services.Images;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Publication;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Services.Publication
{
    public class PublicationService : IPublicationService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IImageService _imageService;

        public PublicationService(
            ApplicationDbContext dbContext,
            IImageService imageService)
        {
            this._dbContext = dbContext;
            this._imageService = imageService;
        }

        public async Task<List<ForumViewModel>> ForumAsync(
            Guid userId)
        {
            var user = await _dbContext.Users
                .FindAsync(userId);

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var model = await _dbContext.Publications
                .Include(x => x.Image)
                .Include(x => x.Studio)
                .Select(p => new ForumViewModel()
                {
                    UserFirstName = user.FirstName,
                    UserLastName = user.LastName,
                    UserProfilePic = user.ProfilePictureUrl,
                    PublicationId = p.Id,
                    ImageUrl = p.Image.UrlPath,
                    Description = p.Description,
                    DatePosted = p.DatePosted,
                    PostUserId = p.UserId,
                    StudioId = p.StudioId,
                    LikeCount = p.Likes.Count,
                    UserName = $"{p.User!.FirstName} {p.User.LastName}",
                    PostUserProfilePic = p.User.ProfilePictureUrl,
                    ViewUrl = "",
                    StudioName = p.Studio.Name,
                    Studios = _dbContext.Studios.Where(x => x.IsApproved)
                        .Select(x => new StudioForumViewModel()
                        {
                            StudioId = x.Id,
                            StudioName = x.Name,
                            StudioRating = x.Ratings.Average(x => x.Value),
                            StudioDescription = x.Description,
                            StudioProfilePic = x.StudioPictureUrl
                        }).ToList(),
                    Post = new CreatePublicationViewModel()
                    {
                        Studios = _dbContext.Studios
                            .Where(x => x.IsApproved)
                            .Select(s => new StudioPostViewModel()
                            {
                                Id = s.Id,
                                StudioName = s.Name
                            }).ToList(),
                        UserFirstName = user.FirstName,
                        UserLastName = user.LastName,
                        UserProfilePic = user.ProfilePictureUrl,
                        ViewUrl = "Forum"

                    }
                }).ToListAsync();

            var publicationIds = model.Select(f => f.PublicationId);
            var likes = _dbContext.Likes
                    .Where(l => l.UserId == userId && publicationIds.Contains(l.PublicationId));

            model.ForEach(f => f.PostLikedByCurrentUser = likes.FirstOrDefault(p => p.UserId == user.Id && p.PublicationId == f.PublicationId) != null);

            return model;
        }

        public async Task CreatePublicationAsync(
            CreatePublicationViewModel model, 
            Guid userId)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var post = new Data.Models.Publication()
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                StudioId = model.StudioId,
                Description = model.Description,
                DatePosted = DateTime.Now,
            };

            await _dbContext.Publications.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            if (model.Image != null)
            {
                await this._imageService.UploadImage(model.Image, "images", post.Id);
            }
        }

        public async Task DeletePublicationAsync(
            Guid postId)
        {
            var model = await _dbContext.Publications
                .FindAsync(postId);

            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            _dbContext.Publications.Remove(model);
            await _dbContext.SaveChangesAsync();
        }
    }
}
