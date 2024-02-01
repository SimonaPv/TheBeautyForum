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

        public async Task<List<ForumViewModel>> ForumAsync()
        {
            var model = await _dbContext.Images
                .Include(p => p.Publication)
                .Select(p => new ForumViewModel()
                {
                    PublicationId = p.PublicationId,
                    UrlPath = p.UrlPath,
                    Description = p.Publication.Description,
                    UserId = p.Publication.UserId,
                    StudioId = p.Publication.StudioId,
                    LikeCount = p.Publication.Likes.Count,
                    CommentCount = p.Publication.Comments.Count,
                    UserName = $"{p.Publication.User.FirstName} {p.Publication.User.LastName}",
                    UserProfilePic = p.Publication.User.ProfilePictureUrl,
                    StudiosNames = _dbContext.Studios.Select(x => x.Name).ToList()
                }).ToListAsync();

            return model;
        }
    }
}
