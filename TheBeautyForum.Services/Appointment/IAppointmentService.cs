using TheBeautyForum.Web.ViewModels.Appointment;

namespace TheBeautyForum.Services.Appointment
{
    public interface IAppointmentService
    {
        Task CreateAppointmentAsync(CreateAppointmentViewModel model, Guid studioId, Guid userId);

        Task DeleteAppointmentAsync(Guid appointmentId);

        Task EditAppointmentAsync(Guid appointmentId, CreateAppointmentViewModel model);

        Task<CreateAppointmentViewModel> LoadCategoriesAsync(Guid studioId);

        Task<CreateAppointmentViewModel> GetAppointmentAsync(Guid appointmentId);
    }
}
