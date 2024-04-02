using TheBeautyForum.Web.ViewModels.Appointment;

namespace TheBeautyForum.Services.Appointment
{
    public interface IAppointmentService
    {
        Task CreateAppointmentAsync(EditAppointmentViewModel model, Guid studioId, Guid userId);

        Task DeleteAppointmentAsync(Guid appointmentId);

        Task EditAppointmentAsync(Guid appointmentId, Guid userId, EditAppointmentViewModel model);

        Task<EditAppointmentViewModel> LoadCategoriesAsync(Guid studioId);

        Task<EditAppointmentViewModel> GetAppointmentAsync(Guid appointmentId);
    }
}
