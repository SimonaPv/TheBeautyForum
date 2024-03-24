using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Publication;
using TheBeautyForum.Services.Users;
using TheBeautyForum.Web.ViewModels.User;

namespace TheBeautyForum.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(
            IUserService userService)
        {
            this._userService = userService;
        }

        public async Task<IActionResult> LoggedProfile()
        {
            var model = await _userService
                .ShowLoggedProfileAsync(Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return View(model);
        }

        public async Task<IActionResult> UserProfile(
            [FromRoute]
            Guid id)
        {
            if (id == Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)))
            {
                var model = await _userService
                    .ShowLoggedProfileAsync(id);

                return RedirectToAction("LoggedProfile", model);
            }
            else
            {
                var model = await _userService
                    .ShowUserProfileAsync(id);

                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var model = await _userService.GetUserAsync(Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProfileViewModel model)
        {
            await _userService.EditUserProfileAsync(model, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return RedirectToAction("LoggedProfile", "User", new { id = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)) });
        }
    }
}
