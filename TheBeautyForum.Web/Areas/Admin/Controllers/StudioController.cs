using Microsoft.AspNetCore.Mvc;
using TheBeautyForum.Services.Studios;

namespace TheBeautyForum.Web.Areas.Admin.Controllers
{
    public class StudioController : BaseController
    {
        private readonly IStudioService _studioService;

        public StudioController(IStudioService studioService)
        {
            this._studioService = studioService;
        }

        public async Task<IActionResult> Delete(
            [FromRoute]
            Guid id)
        {
            await _studioService.DeleteStudioAsync(id);

            return RedirectToAction("All", "Studio");
        }
    }
}
