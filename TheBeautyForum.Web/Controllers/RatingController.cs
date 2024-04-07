using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Rating;
using TheBeautyForum.Web.ViewModels.Rating;

namespace TheBeautyForum.Web.Controllers
{
    /// <summary>
    /// Represents the rating controller.
    /// </summary>
    [Authorize]
    public class RatingController : Controller
    {
        private readonly IRatingService _ratingService;

        /// <summary>
        /// Initialize new instance of <see cref="RatingController"/> class.
        /// </summary>
        /// <param name="ratingService"></param>
        public RatingController(
            IRatingService ratingService)
        {
            this._ratingService = ratingService;
        }

        /// <summary>
        /// Updates rating.
        /// </summary>
        /// <param name="model">the model for updating the rating</param>
        /// <returns>The view "LoggedProfile".</returns>
        [HttpPost]
        public async Task<IActionResult> UpdateRating(
            RatingViewModel model)
        {
            try
            {
                if (User.IsInRole("Administrator") || User.IsInRole("StudioCreator"))
                {
                    return RedirectToAction("LoggedProfile", "User");
                }

                await _ratingService.UpdateStudioRatingAsync(model, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

                return RedirectToAction("LoggedProfile", "User");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
