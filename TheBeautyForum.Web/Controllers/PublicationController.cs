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
            if (this.User.IsInRole("Administrator"))
            {
                return RedirectToAction("Profile", "Studio", new { id = model.StudioId });
            }

            if (model.Image != null && model.Image.Length > 10485760)
            {
                ModelState.AddModelError(nameof(model.Image), "your file size exceeds the maximum allowed file size");

                if (model.ViewUrl == "Forum")
                {
                    return RedirectToAction("Forum", "Publication", model);
                }
                else if (model.ViewUrl == "LoggedProfile")
                {
                    return RedirectToAction("LoggedProfile", "User", model);
                }
                else
                {
                    return RedirectToAction("Profile", "Studio", model);
                }
            }

            if (!ModelState.IsValid)
            {
                if (model.ViewUrl == "Forum")
                {
                    return RedirectToAction("Forum", "Publication", model);
                }
                else if (model.ViewUrl == "LoggedProfile")
                {
                    return RedirectToAction("LoggedProfile", "User", model);
                }
                else
                {
                    return RedirectToAction("Profile", "Studio", model);
                }
            }

            await _publicationService.CreatePublicationAsync(model, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            if (model.ViewUrl == "Forum")
            {
                return RedirectToAction("Forum", "Publication", model);
            }
            else if (model.ViewUrl == "LoggedProfile")
            {
                return RedirectToAction("LoggedProfile", "User", model);
            }
            else
            {
                return RedirectToAction("Profile", "Studio", model);
            }
        }

        public async Task<IActionResult> Delete(
            Guid publicationId, string viewUrl, Guid? studioId = null)
        {
            await _publicationService.DeletePublicationAsync(publicationId);

            if (viewUrl == "Forum")
            {
                return RedirectToAction("Forum", "Publication");
            }
            else if (viewUrl == "StudioProfile")
            {
                return RedirectToAction("Profile", "Studio", new { id = studioId });
            }
            else
            {
                return RedirectToAction("LoggedProfile", "User", new { id = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)) });
            }
        }
    }
}
