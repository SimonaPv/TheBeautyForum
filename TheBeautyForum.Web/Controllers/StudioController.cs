using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Studios;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Web.Controllers
{
    [Authorize]
    public class StudioController : Controller
    {
        private readonly IStudioService _studioService;

        public StudioController(
            IStudioService studioService)
        {
            _studioService = studioService;
        }

        public async Task<IActionResult> All(
            FilterViewModel model)
        {
            var studios  = await _studioService.GetAllStudiosAsync(model);

            return View(studios);
        }

        public async Task<IActionResult> Profile(
            [FromRoute]
            Guid id)
        {
            var model = await _studioService.ShowStudioProfileAsync(id, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return View(model);
        }
    }
}
