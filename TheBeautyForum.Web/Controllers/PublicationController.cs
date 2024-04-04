using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Publication;
using TheBeautyForum.Web.ViewModels.Publication;

namespace TheBeautyForum.Web.Controllers
{
    /// <summary>
    /// Represents the publication controller.
    /// </summary>
    [Authorize]
    public class PublicationController : Controller
    {
        private readonly IPublicationService _publicationService;

        /// <summary>
        /// Initialize new instance of <see cref="PublicationController"/> class.
        /// </summary>
        /// <param name="publicationService"></param>
        public PublicationController(
            IPublicationService publicationService)
        {
            this._publicationService = publicationService;
        }

        /// <summary>
        /// Gets the forum.
        /// </summary>
        /// <returns>The view "Forum".</returns>
        public async Task<IActionResult> Forum()
        {
            var model = await _publicationService.ForumAsync(Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return View(model);
        }

        /// <summary>
        /// Creates publication.
        /// </summary>
        /// <param name="model">the model for the creating the publication</param>
        /// <returns>Based on the user's role.</returns>
        [HttpPost]
        public async Task<IActionResult> Create(
            CreatePublicationViewModel model)
        {
            if (this.User.IsInRole("Administrator") || this.User.IsInRole("StudioCreator"))
            {
                return RedirectToAction("Forum", "Publication");
            }

            if (model.Image != null && model.Image.Length > 10485760)
            {
                ModelState.AddModelError(nameof(model.Image), "Your file is too big.");
            }

            if (model.StudioId == Guid.Empty)
            {
                ModelState.AddModelError(nameof(model.StudioId), "This field is required");
            }

            if (!ModelState.IsValid)
            {
                if (model.ViewUrl == "Forum")
                {
                    return RedirectToAction("Forum", "Publication", model);
                }
                else
                {
                    return RedirectToAction("LoggedProfile", "User", model);
                }
            }

            await _publicationService.CreatePublicationAsync(model, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            if (model.ViewUrl == "Forum")
            {
                return RedirectToAction("Forum", "Publication", model);
            }
            else
            {
                return RedirectToAction("LoggedProfile", "User", model);
            }
        }

        /// <summary>
        /// Deletes publication.
        /// </summary>
        /// <param name="publicationId">the ID of the publication</param>
        /// <param name="viewUrl">the view to return to</param>
        /// <param name="studioId">the ID of the studio</param>
        /// <returns>Based on the user's role.</returns>
        public async Task<IActionResult> Delete(
            Guid publicationId, 
            string viewUrl, 
            Guid? studioId = null)
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
