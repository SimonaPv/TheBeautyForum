using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Appointment;
using TheBeautyForum.Web.ViewModels.Appointment;

namespace TheBeautyForum.Web.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            this._appointmentService = appointmentService;
        }

        [HttpGet]
        public async Task<IActionResult> Create(
            [FromRoute]
            Guid id)
        {
            var model = await _appointmentService.LoadCategoriesAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAppointmentViewModel model,
            [FromRoute]
            Guid id)
        {
            model.StartDate = model.StartDate.AddHours(model.StartDateHour);

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

        public async Task<IActionResult> Delete(Guid appointmentId)
        {
            await _appointmentService.DeleteAppointmentAsync(appointmentId);

            return RedirectToAction("LoggedProfile", "User");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid appointmentId)
        {
            var model = await _appointmentService.GetAppointmentAsync(appointmentId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(
            [FromRoute]
            Guid id, 
            CreateAppointmentViewModel model)
        {
            model.StartDate = model.StartDate.AddHours(model.StartDateHour);
                
            if (model.StartDate < DateTime.Now)
            {
                ModelState.AddModelError(nameof(model.StartDate), "Invalid date.");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _appointmentService.EditAppointmentAsync(id, (Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier))), model);

            return RedirectToAction("LoggedProfile", "User");
        }
    }
}
