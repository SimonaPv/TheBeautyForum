using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Users;

namespace TheBeautyForum.Web.Areas.StudioCreator.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        public async Task<IActionResult> LoggedProfile()
        {
            var model = await _userService.ShowStudioCreatorLoggedProfileAsync((Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier))));

            return View(model);
        }
    }
}
