using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Users;

namespace TheBeautyForum.Web.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
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
    }
}
