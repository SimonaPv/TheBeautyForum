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

        public async Task<List<ForumViewModel>> ForumAsync(Guid userId)
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
                    CommentCount = p.Comments.Count,
                    UserName = $"{p.User!.FirstName} {p.User.LastName}",
                    PostUserProfilePic = p.User.ProfilePictureUrl,
                    StudioName = p.Studio.Name,
                    Studios = _dbContext.Studios.Select(x => new StudioForumViewModel()
                    {
                        StudioId = x.Id,
                        StudioName = x.Name
                    }).ToList(),
                    Post = new CreatePublicationViewModel()
                    {
                        Studios = _dbContext.Studios
                            .Select(s => new StudioPostViewModel()
                            {
                                Id = s.Id,
                                StudioName = s.Name
                            }).ToList(),
                        UserFirstName = user.FirstName,
                        UserLastName = user.LastName,
                        UserProfilePic = user.ProfilePictureUrl,
                        ActionUrl = "Forum"
                    }
                }).ToListAsync();

            return model;
        }

        public async Task CreatePublicationAsync(CreatePublicationViewModel model, Guid userId)
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

        public async Task<CreatePublicationViewModel> LoadAllStudiosAsync(Guid userId)
        {
            var user = await _dbContext.Users.FindAsync(userId);

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var model = new CreatePublicationViewModel()
            {
                Studios = await _dbContext.Studios
                    .Select(s => new StudioPostViewModel()
                    {
                        Id = s.Id,
                        StudioName = s.Name
                    })
                    .ToListAsync(),
                UserFirstName = user.FirstName,
                UserLastName = user.LastName,
                UserProfilePic = user.ProfilePictureUrl
            };

            return model;
        }
    }
}
