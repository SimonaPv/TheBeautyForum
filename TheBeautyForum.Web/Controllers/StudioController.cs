using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Completion;
using TheBeautyForum.Services.Studios;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Web.Controllers
{
    public class StudioController : Controller
    {
        private readonly IStudioService _studioService;

        public StudioController(IStudioService studioService)
        {
            _studioService = studioService;
        }

        public async Task<IActionResult> All(FilterViewModel model)
        {
            var studios  = await _studioService.GetAllStudiosAsync(model);

            return View(studios);
        }

        public async Task<IActionResult> Profile(
            [FromRoute]
            Guid id)
        {
            var model = await _studioService.ShowStudioProfileAsync(id);

            return View(model);
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
            await _studioService.EditStudioProfileAsync(model, id);

            return RedirectToAction("Profile", "Studio", new { id = id });
        }
    }
}
