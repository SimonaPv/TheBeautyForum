using Microsoft.AspNetCore.Mvc;

namespace TheBeautyForum.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
