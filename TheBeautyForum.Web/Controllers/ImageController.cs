using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Images;
using TheBeautyForum.Services.Publication;
using TheBeautyForum.Web.ViewModels.Publication;

namespace TheBeautyForum.Web.Controllers
{
    [Authorize]
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;
        private readonly IPublicationService _publicationService;

        public ImageController(IImageService imageService, IPublicationService publicationService)
        {
            this._imageService = imageService;
            this._publicationService = publicationService;

        }

        public async Task<IActionResult> Forum()
        {
            var model = await _imageService.ForumAsync(Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePublicationViewModel model)
        {
            await _publicationService.CreatePublicationAsync(model, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return RedirectToAction("Forum");
        }
    }
}
