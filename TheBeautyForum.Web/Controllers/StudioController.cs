using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Studios;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Web.Controllers
{
    /// <summary>
    /// Represents the studio controller.
    /// </summary>
    [Authorize]
    public class StudioController : Controller
    {
        private readonly IStudioService _studioService;

        /// <summary>
        /// Initialize new instance of <see cref="StudioController"/> class.
        /// </summary>
        /// <param name="studioService"></param>
        public StudioController(
            IStudioService studioService)
        {
            _studioService = studioService;
        }

        /// <summary>
        /// Gets all studio.
        /// </summary>
        /// <param name="model">the model for the filter of the studios</param>
        /// <returns>The view "All".</returns>
        public async Task<IActionResult> All(
            FilterViewModel model)
        {
            var studios  = await _studioService.GetAllStudiosAsync(model);

            return View(studios);
        }

        /// <summary>
        /// Gets the studio profile.
        /// </summary>
        /// <param name="id">the ID of the studio</param>
        /// <returns>The view "Profile".</returns>
        public async Task<IActionResult> Profile(
            [FromRoute]
            Guid id)
        {
            var model = await _studioService.ShowStudioProfileAsync(id, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return View(model);
        }
    }
}
