using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Studios;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Web.Areas.StudioCreator.Controllers
{
    public class StudioController : BaseController
    {
        private readonly IStudioService _studioService;

        public StudioController(IStudioService studioService)
        {
            this._studioService = studioService;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = await _studioService.CreateStudioCategoriesAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStudioViewModel model)
        {
            if (!model.CategoryIds.Any())
            {
                ModelState.AddModelError(nameof(model.CategoryIds), "Please, select procedures.");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _studioService.CreateStudioAsync(model, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return RedirectToAction("LoggedProfile", "User");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(
            [FromRoute]
            Guid id)
        {
            var model = await _studioService.GetStudioAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(
            EditStudioProfileViewModel model,
            [FromRoute]
            Guid id)
        {
            if (!model.CategoryIds.Any())
            {
                ModelState.AddModelError(nameof(model.CategoryIds), "Please, select procedures.");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _studioService.EditStudioProfileAsync(model, id);

            return RedirectToAction("Profile", "Studio", new { id = id });
        }
    }
}
