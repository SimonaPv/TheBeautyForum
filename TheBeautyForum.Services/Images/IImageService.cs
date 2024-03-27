using Microsoft.AspNetCore.Http;
using TheBeautyForum.Data.Models;

namespace TheBeautyForum.Services.Images
{
    public interface IImageService
    {
        Task<Image> UploadImage(IFormFile imageFile, string nameFolder, Guid postId);

        Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user);

        Task<string> UploadImage(IFormFile imageFile, string nameFolder, Studio studio);
    }
}
