using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Web.Data;

namespace TheBeautyForum.Services.Images
{
    /// <summary>
    /// Represents an image service.
    /// </summary>
    public class ImageService : IImageService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly Cloudinary _cloudinary;

        /// <summary>
        /// Initialize a new instance of the <see cref="ImageService"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="cloudinary"></param>
        public ImageService(
            ApplicationDbContext dbContext,
            Cloudinary cloudinary)
        {
            this._dbContext = dbContext;
            this._cloudinary = cloudinary;
        }

        /// <inheritdoc/>
        public async Task<Image> UploadImage(
            IFormFile imageFile, 
            string nameFolder, 
            Guid postId)
        {
            using var stream = imageFile.OpenReadStream();
            var image = new Image();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(image.Id.ToString(), stream),
                Folder = nameFolder,
            };

            var result = await this._cloudinary
                .UploadAsync(uploadParams);

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

        /// <inheritdoc/>
        public async Task<string> UploadImage(
            IFormFile imageFile, 
            string nameFolder, 
            User user)
        {
            using var stream = imageFile.OpenReadStream();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(user.Id.ToString(), stream),
                Folder = nameFolder,
            };

            var result = await this._cloudinary
                .UploadAsync(uploadParams);

            if (result.Error != null)
            {
                throw new InvalidOperationException(result.Error.Message);
            }

            user.ProfilePictureUrl = result.Url.ToString();

            this._dbContext.Update(user);
            await this._dbContext.SaveChangesAsync();

            return user.ProfilePictureUrl;
        }

        /// <inheritdoc/>
        public async Task<string> UploadImage(
            IFormFile imageFile, 
            string nameFolder, 
            Studio studio)
        {
            using var stream = imageFile.OpenReadStream();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(studio.Id.ToString(), stream),
                Folder = nameFolder,
            };

            var result = await this._cloudinary
                .UploadAsync(uploadParams);

            if (result.Error != null)
            {
                throw new InvalidOperationException(result.Error.Message);
            }

            studio.StudioPictureUrl = result.Url.ToString();

            this._dbContext.Update(studio);
            await this._dbContext.SaveChangesAsync();

            return studio.StudioPictureUrl;
        }
    }
}
