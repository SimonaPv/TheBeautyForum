using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Publication;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Services.Publication
{
    public class PublicationService : IPublicationService
    {
        private readonly ApplicationDbContext _dbContext;

        public PublicationService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<ForumViewModel>> ForumAsync(Guid userId)
        {
            var user = await _dbContext.Users
                .FindAsync(userId);

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var postWithoutImage = await _dbContext.Publications
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
                        UserProfilePic = user.ProfilePictureUrl
                    }
                }).ToListAsync();

            return postWithoutImage;
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

            var image = new Image();

            if (model.ImageUrl != null)
            {
                image = new Image()
                {
                    Id = Guid.NewGuid(),
                    UrlPath = model.ImageUrl,
                    PublicationId = post.Id
                };
            }

            if (image.UrlPath != null)
            {
                post.Image = image;
                await _dbContext.Images.AddAsync(image);
            }

            await _dbContext.Publications.AddAsync(post);
            await _dbContext.SaveChangesAsync();
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
