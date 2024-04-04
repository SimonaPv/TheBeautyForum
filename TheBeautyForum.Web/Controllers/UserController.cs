using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Users;
using TheBeautyForum.Web.ViewModels.User;

namespace TheBeautyForum.Web.Controllers
{
    /// <summary>
    /// Represents the user controller.
    /// </summary>
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        /// <summary>
        /// Initialize new instance of <see cref="UserController"/> class.
        /// </summary>
        /// <param name="userService"></param>
        public UserController(
            IUserService userService)
        {
            this._userService = userService;
        }

        /// <summary>
        /// Gets the profile of the logged user.
        /// </summary>
        /// <returns>The view "LoggedProfile"</returns>
        public async Task<IActionResult> LoggedProfile()
        {
            var model = await _userService
                .ShowLoggedProfileAsync(Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return View(model);
        }

        /// <summary>
        /// Gets the profile of the user.
        /// </summary>
        /// <param name="id">the ID of the user</param>
        /// <returns>The view "LoggedProfile".</returns>
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
                    .ShowUserProfileAsync(id, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

                return View(model);
            }
        }

        /// <summary>
        /// Edits user's profile.
        /// </summary>
        /// <returns>The view "Edit".</returns>
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var model = await _userService.GetUserAsync(Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return View(model);
        }

        /// <summary>
        /// Edits user's profile.
        /// </summary>
        /// <param name="model">the model for editing user's profile</param>
        /// <returns>The view "LoggedProfile".</returns>
        [HttpPost]
        public async Task<IActionResult> Edit(
            EditProfileViewModel model)
        {
            await _userService.EditUserProfileAsync(model, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return RedirectToAction("LoggedProfile", "User", new { id = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)) });
        }
    }
}
