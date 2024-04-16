using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Users;
using TheBeautyForum.Web.ViewModels.User;

namespace TheBeautyForum.Web.Areas.StudioCreator.Controllers
{
    /// <summary>
    /// Represents the user controller.
    /// </summary>
    public class UserController : BaseController
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
        /// <returns>The view "LoggedProfile".</returns>
        public async Task<IActionResult> LoggedProfile()
        {
            try
            {
                var model = await _userService.ShowStudioCreatorLoggedProfileAsync((Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier))));

                return View(model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Edits user's profile.
        /// </summary>
        /// <returns>The view "Edit".</returns>
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            try
            {
                var model = await _userService.GetUserAsync(Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

                return View(model);
            }
            catch (Exception)
            {
                throw;
            }
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
            try
            {
                await _userService.EditUserProfileAsync(model, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

                return RedirectToAction("LoggedProfile", "User", new { id = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)) });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
