using Microsoft.AspNetCore.Mvc;
using TheBeautyForum.Services.Images;

namespace TheBeautyForum.Web.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            this._imageService = imageService;
        }

        public async Task<IActionResult> Forum()
        {
            var model = await _imageService.ForumAsync();

            return View(model);
        }
    }
}
