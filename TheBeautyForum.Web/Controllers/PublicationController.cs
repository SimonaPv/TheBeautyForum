using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Publication;
using TheBeautyForum.Web.ViewModels.Publication;

namespace TheBeautyForum.Web.Controllers
{
    [Authorize]
    public class PublicationController : Controller
    {
        private readonly IPublicationService _publicationService;

        public PublicationController(IPublicationService publicationService)
        {
            this._publicationService = publicationService;
        }

        public async Task<IActionResult> Forum()
        {
            var model = await _publicationService.ForumAsync(Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePublicationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                if (model.ActionUrl == "Forum")
                {
                    return RedirectToAction("Forum", "Publication", model);
                }
                else if (model.ActionUrl == "LoggedProfile")
                {
                    return RedirectToAction("LoggedProfile", "User", model);
                }
                else
                {
                    return RedirectToAction("Profile", "Studio", model);
                }
            }

            await _publicationService.CreatePublicationAsync(model, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            if (model.ActionUrl == "Forum")
            {
                return RedirectToAction("Forum", "Publication", model);
            }
            else if (model.ActionUrl == "LoggedProfile")
            {
                return RedirectToAction("LoggedProfile", "User", model);
            }
            else
            {
                return RedirectToAction("Profile", "Studio", model);
            }
        }

        public async Task<IActionResult> Delete(
            [FromRoute]
            Guid id)
        {
            await _publicationService.DeletePublicationAsync(id);

            return RedirectToAction("LoggedProfile", "User", new { id = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)) });
        }

        //[HttpGet]
        //public async Task<IActionResult> Edit(
        //    [FromRoute]
        //    Guid id)
        //{
        //    var model = await _publicationService.GetPostAsync(id);

        //    return View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(CreatePublicationViewModel model)
        //{
        //    return View();
        //}
    }
}
