using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Image;

namespace TheBeautyForum.Services.Images
{
    public class ImageService : IImageService
    {
        private readonly ApplicationDbContext _dbContext;

        public ImageService(ApplicationDbContext dbContext)
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

            var model = await _dbContext.Images
                .Include(p => p.Publication)
                .Select(p => new ForumViewModel()
                {
                    UserFirstName = user.FirstName,
                    UserLastName = user.LastName,
                    UserProfilePic = user.ProfilePictureUrl,
                    PublicationId = p.PublicationId,
                    Images = p.Publication.Images.Select(i => i.UrlPath).ToList(),
                    Description = p.Publication.Description,
                    DatePosted = p.Publication.DatePosted,
                    PostUserId = p.Publication.UserId,
                    StudioId = p.Publication.StudioId,
                    LikeCount = p.Publication.Likes.Count,
                    CommentCount = p.Publication.Comments.Count,
                    UserName = $"{p.Publication.User!.FirstName} {p.Publication.User.LastName}",
                    PostUserProfilePic = p.Publication.User.ProfilePictureUrl,
                    StudiosNames = _dbContext.Studios.Select(x => x.Name).ToList()
                }).ToListAsync();

            return model;
        }
    }
}
