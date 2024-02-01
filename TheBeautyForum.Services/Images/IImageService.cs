using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Web.ViewModels.Image;

namespace TheBeautyForum.Services.Images
{
    public interface IImageService
    {
        Task<List<ForumViewModel>> ForumAsync();
    }
}
