using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Users;

namespace TheBeautyForum.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        public async Task<IActionResult> Profile()
        {
            var model = await _userService
                .ShowProfileAsync(Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return View(model);
        }
    }
}
