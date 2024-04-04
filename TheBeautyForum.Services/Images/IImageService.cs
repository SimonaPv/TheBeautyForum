using Microsoft.AspNetCore.Http;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Services.Images
{
    /// <summary>
    /// Provides access to images.
    /// </summary>
    public interface IImageService
    {
        /// <summary>
        /// Uploads images for post.
        /// </summary>
        /// <param name="imageFile">the file</param>
        /// <param name="nameFolder">the name of the folder</param>
        /// <param name="postId">the ID of the post</param>
        /// <returns>The image.</returns>
        Task<Image> UploadImage(IFormFile imageFile, string nameFolder, Guid postId);

        /// <summary>
        /// Uploads image for user.
        /// </summary>
        /// <param name="imageFile">the file</param>
        /// <param name="nameFolder">the name of the folder</param>
        /// <param name="user">the user of the image</param>
        /// <returns>The image URL.</returns>
        Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user);

        /// <summary>
        /// Uploads image for studio.
        /// </summary>
        /// <param name="imageFile">the file</param>
        /// <param name="nameFolder">the name of the folder</param>
        /// <param name="studio">the studio of the image</param>
        /// <returns>The image URL.</returns>
        Task<string> UploadImage(IFormFile imageFile, string nameFolder, Studio studio);
    }
}
