using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Appointment;
using TheBeautyForum.Services.Category;
using TheBeautyForum.Web.ViewModels.Appointment;

namespace TheBeautyForum.Web.Controllers
{
    /// <summary>
    /// Represents the appointment controller.
    /// </summary>
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        private readonly ICategoryService _categoryService;

        /// <summary>
        /// Initialize new instance of <see cref="AppointmentController"/> class.
        /// </summary>
        /// <param name="appointmentService"></param>
        /// <param name="categoryService"></param>
        public AppointmentController(
            IAppointmentService appointmentService,
            ICategoryService categoryService)
        {
            this._appointmentService = appointmentService;
            this._categoryService = categoryService;
        }

        /// <summary>
        /// Creates appointment.
        /// </summary>
        /// <param name="id">the ID of the studio for which the appointment is created</param>
        /// <returns>The view "Create".</returns>
        [HttpGet]
        public async Task<IActionResult> Create(
            [FromRoute]
            Guid id)
        {
            try
            {
                if (this.User.IsInRole("Administrator") || this.User.IsInRole("StudioCreator"))
                {
                    return RedirectToAction("Profile", "Studio", new { id = id });
                }

                var model = await _appointmentService.LoadCategoriesAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Creates appointment.
        /// </summary>
        /// <param name="model">the model for creating the studio</param>
        /// <param name="id">the ID for the studio</param>
        /// <returns>The view "Profile"</returns>
        [HttpPost]
        public async Task<IActionResult> Create(
            CreateAppointmentViewModel model,
            [FromRoute]
            Guid id)
        {
            try
            {
                model.StartDate = model.StartDate.AddHours(model.StartDateHour);
                model.Categories = await _categoryService.LoadCategoriesAsync(id);

                if (model.StartDate < DateTime.Now)
                {
                    ModelState.AddModelError(nameof(model.StartDate), "Invalid date.");
                }

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                await _appointmentService.CreateAppointmentAsync(model, id, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

                return RedirectToAction("Profile", "Studio", new { id = id });
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes appointment.
        /// </summary>
        /// <param name="appointmentId">the ID of the appointment</param>
        /// <returns>The view "LoggedProfile".</returns>
        public async Task<IActionResult> Delete(
            Guid appointmentId)
        {
            try
            {
                await _appointmentService.DeleteAppointmentAsync(appointmentId);

                return RedirectToAction("LoggedProfile", "User");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Edits appointment.
        /// </summary>
        /// <param name="appointmentId">the ID of the appointment</param>
        /// <returns>The view "Edit".</returns>
        [HttpGet]
        public async Task<IActionResult> Edit(
            Guid appointmentId)
        {
            try
            {
                var model = await _appointmentService.GetAppointmentAsync(appointmentId);

                return View(model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Edits appointment.
        /// </summary>
        /// <param name="id">the ID of the studio</param>
        /// <param name="model">the model for creating the appointment</param>
        /// <returns>The view "LoggedProfile"</returns>
        [HttpPost]
        public async Task<IActionResult> Edit(
            [FromRoute]
            Guid id,
            CreateAppointmentViewModel model)
        {
            try
            {
                model.StartDate = model.StartDate.AddHours(model.StartDateHour);
                model.Categories = await _categoryService.LoadCategoriesAsync(model.StudioId);

                if (model.StartDate < DateTime.Now)
                {
                    ModelState.AddModelError(nameof(model.StartDate), "Invalid date.");
                }

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                await _appointmentService.EditAppointmentAsync(id, model);

                return RedirectToAction("LoggedProfile", "User");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
