using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Studios;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Web.Areas.StudioCreator.Controllers
{
    /// <summary>
    /// Represents the studio controller.
    /// </summary>
    public class StudioController : BaseController
    {
        private readonly IStudioService _studioService;

        /// <summary>
        /// Initialize new instance of <see cref="StudioController"/> class.
        /// </summary>
        /// <param name="studioService"></param>
        public StudioController(
            IStudioService studioService)
        {
            this._studioService = studioService;
        }

        /// <summary>
        /// Creates studio.
        /// </summary>
        /// <returns>The view "Create"</returns>
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = await _studioService.CreateStudioCategoriesAsync();

            return View(model);
        }

        /// <summary>
        /// Creates studio.
        /// </summary>
        /// <param name="model">the model for creating the studio</param>
        /// <returns>The view "LoggedProfile"</returns>
        [HttpPost]
        public async Task<IActionResult> Create(
            CreateStudioViewModel model)
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

        /// <summary>
        /// Edits studio.
        /// </summary>
        /// <param name="id">the ID of the studio that has to be edited</param>
        /// <returns>The view "Edit"</returns>
        [HttpGet]
        public async Task<IActionResult> Edit(
            [FromRoute]
            Guid id)
        {
            var model = await _studioService.GetStudioAsync(id);

            return View(model);
        }

        /// <summary>
        /// Edits studio.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="id">the ID of the studio that has to be edited</param>
        /// <returns>The view "Profile"</returns>
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
