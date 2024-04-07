using Microsoft.AspNetCore.Mvc;
using TheBeautyForum.Services.Studios;

namespace TheBeautyForum.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// Represents studio controller.
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
        /// Deletes studio.
        /// </summary>
        /// <param name="id">the ID of the studio that has to be deleted</param>
        /// <returns>The view "All"</returns>
        public async Task<IActionResult> Delete(
            [FromRoute]
            Guid id)
        {
            try
            {
                await _studioService.DeleteStudioAsync(id);

                return RedirectToAction("All", "Studio");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
