using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheBeautyForum.Services.Home;

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
            try
            {
                if (User?.Identity?.IsAuthenticated ?? false)
                {
                    return RedirectToAction("Forum", "Publication");
                }

                var model = await _homeService.HomeAsync();

                return View(model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error(int statusCode)
        {
            return View();
        }
    }
}