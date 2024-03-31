using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Rating;
using TheBeautyForum.Web.ViewModels.Rating;

namespace TheBeautyForum.Web.Controllers
{
    [Authorize]
    public class RatingController : Controller
    {
        private readonly IRatingService _ratingService;

        public RatingController(
            IRatingService ratingService)
        {
            this._ratingService = ratingService;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRating(
            RatingViewModel model)
        {
            if (User.IsInRole("Administrator") || User.IsInRole("StudioCreator"))
            {
                return RedirectToAction("LoggedProfile", "User");
            }

            await _ratingService.UpdateStudioRatingAsync(model, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return RedirectToAction("LoggedProfile", "User");
        }
    }
}
