using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using TheBeautyForum.Services.Studios;

namespace TheBeautyForum.Web.Controllers
{
    public class StudioController : Controller
    {
        private readonly IStudioService _studioService;

        public StudioController(IStudioService studioService)
        {
            _studioService = studioService;
        }

        public async Task<IActionResult> Profile(
            [FromRoute]
            Guid id)
        {
            var model = await _studioService.ShowStudioProfileAsync(id);

            return View(model);
        }
    }
}
