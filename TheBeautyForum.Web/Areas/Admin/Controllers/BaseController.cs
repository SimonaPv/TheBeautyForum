using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TheBeautyForum.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = "Administrator")]
    public class BaseController : Controller
    {
    }
}
