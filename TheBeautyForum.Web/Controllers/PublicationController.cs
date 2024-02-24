using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Publication;
using TheBeautyForum.Web.ViewModels.Publication;

namespace TheBeautyForum.Web.Controllers
{
    [Authorize]
    public class PublicationController : Controller
    {
        private readonly IPublicationService _publicationService;

        public PublicationController(IPublicationService publicationService)
        {
            this._publicationService = publicationService;
        }

        public async Task<IActionResult> Forum()
        {
            var model = await _publicationService.ForumAsync(Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePublicationViewModel model)
        {
            await _publicationService.CreatePublicationAsync(model, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return RedirectToAction("Forum", "Publication");
        }
    }
}
