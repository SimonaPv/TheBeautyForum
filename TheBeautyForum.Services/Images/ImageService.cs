using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Image;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Services.Images
{
    public class ImageService : IImageService
    {
        private readonly Cloudinary _cloudinary;
        private readonly ApplicationDbContext _dbContext;

        public ImageService(
            ApplicationDbContext dbContext, 
            Cloudinary cloudinary)
        {
            this._dbContext = dbContext;
            this._cloudinary = cloudinary;
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
                    StudioName = p.Publication.Studio.Name,
                    Studios = _dbContext.Studios.Select(x => new StudioForumViewModel()
                    {
                        StudioId = x.Id,
                        StudioName = x.Name
                    }).ToList()
                }).ToListAsync();

            return model;
        }

        public async Task<Image> UploadImage(IFormFile imageFile, string nameFolder, Guid postId)
        {
            using var stream = imageFile.OpenReadStream();
            var image = new Image();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(image.Id.ToString(), stream),
                Folder = nameFolder,
            };

            var result = await this._cloudinary.UploadAsync(uploadParams);

            if (result.Error != null)
            {
                throw new InvalidOperationException(result.Error.Message);
            }

            image.UrlPath = result.Url.ToString();
            image.PublicationId = postId;

            await this._dbContext.AddAsync(image);
            await this._dbContext.SaveChangesAsync();

            return image;
        }

        public async Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user)
        {
            using var stream = imageFile.OpenReadStream();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(user.Id.ToString(), stream),
                Folder = nameFolder,
            };

            var result = await this._cloudinary.UploadAsync(uploadParams);
            if (result.Error != null)
            {
                throw new InvalidOperationException(result.Error.Message);
            }

            user.ProfilePictureUrl = result.Url.ToString();

            this._dbContext.Update(user);
            await this._dbContext.SaveChangesAsync();

            return user.ProfilePictureUrl;
        }
    }
}
