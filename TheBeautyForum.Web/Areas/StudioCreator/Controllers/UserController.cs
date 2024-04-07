using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Users;

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
    }
}
