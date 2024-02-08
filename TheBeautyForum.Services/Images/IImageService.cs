using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Web.ViewModels.Image;

namespace TheBeautyForum.Services.Images
{
    public interface IImageService
    {
        Task<List<ForumViewModel>> ForumAsync(Guid userId);

        Task<Image> UploadImage(IFormFile imageFile, string nameFolder, Guid postId);

        Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user);
    }
}
