using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Users;

namespace TheBeautyForum.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// Represents user controller.
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
        /// Gets logged user profile.
        /// </summary>
        /// <returns>The view "LoggedProfile"</returns>
        public async Task<IActionResult> LoggedProfile()
        {
            try
            {
                var model = await _userService
               .ShowAdminProfileAsync(Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

                return View(model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Approves studio.
        /// </summary>
        /// <param name="id">the ID of the studio that has to be approved</param>
        /// <returns>The view "LoggedProfile"</returns>
        public async Task<IActionResult> Approve(Guid id)
        {
            try
            {
                await _userService.ApproveStudioAsync(id);

                return RedirectToAction("LoggedProfile", "User");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Declines studio.
        /// </summary>
        /// <param name="id">the ID of the studio that has to be declined</param>
        /// <returns>The view "LoggedProfile"</returns>
        public async Task<IActionResult> Decline(Guid id)
        {
            try
            {
                await _userService.DeclineStudioAsync(id);

                return RedirectToAction("LoggedProfile", "User");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
