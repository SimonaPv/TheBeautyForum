using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Appointment;
using TheBeautyForum.Web.ViewModels.Appointment;

namespace TheBeautyForum.Web.Controllers
{
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
            await _appointmentService.CreateAppointmentAsync(model, id, Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));

            return RedirectToAction("Profile", "Studio", new { id = id });
        }
    }
}
