using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheBeautyForum.Services.Home;
using TheBeautyForum.Web.Models;

namespace TheBeautyForum.Web.Controllers
{
    /// <summary>
    /// Represents the home controller.
    /// </summary>
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        /// <summary>
        /// Initialize new instance of <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="homeService"></param>
        public HomeController(
            IHomeService homeService)
        {
            this._homeService = homeService;
        }

        /// <summary>
        /// Gets home page.
        /// </summary>
        /// <returns>The view "Home".</returns>
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Forum", "Publication");
            }

            var model = await _homeService.HomeAsync();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}