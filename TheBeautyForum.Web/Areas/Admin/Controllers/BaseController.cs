using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TheBeautyForum.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// Represents the base controller.
    /// </summary>
    [Area("Admin")]
    [Route("/Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = "Administrator")]
    public class BaseController : Controller
    {
    }
}
