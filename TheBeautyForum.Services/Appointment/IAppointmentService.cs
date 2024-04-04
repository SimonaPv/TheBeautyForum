using TheBeautyForum.Web.ViewModels.Appointment;

namespace TheBeautyForum.Services.Appointment
{
    /// <summary>
    /// Provides access to appointments.
    /// </summary>
    public interface IAppointmentService
    {
        /// <summary>
        /// Creates an appointment.
        /// </summary>
        /// <param name="model">the model for creating the appointment</param>
        /// <param name="studioId">the ID of the studio</param>
        /// <param name="userId">the ID of the user</param>
        Task CreateAppointmentAsync(CreateAppointmentViewModel model, Guid studioId, Guid userId);

        /// <summary>
        /// Deletes appointment by ID.
        /// </summary>
        /// <param name="appointmentId">the ID of the appointment</param>
        Task DeleteAppointmentAsync(Guid appointmentId);

        /// <summary>
        /// Edit appointment by ID.
        /// </summary>
        /// <param name="appointmentId">the ID of the appointment</param>
        /// <param name="model">the model for editing the appointment</param>
        Task EditAppointmentAsync(Guid appointmentId, CreateAppointmentViewModel model);

        /// <summary>
        /// Loads categories for studio to use in create appointment.
        /// </summary>
        /// <param name="studioId">the ID of the studio</param>
        /// <returns>Appointment with loaded categories.</returns>
        Task<CreateAppointmentViewModel> LoadCategoriesAsync(Guid studioId);

        /// <summary>
        /// Gets appointment by ID.
        /// </summary>
        /// <param name="appointmentId">the ID of the appointment</param>
        /// <returns>The appointment.</returns>
        Task<CreateAppointmentViewModel> GetAppointmentAsync(Guid appointmentId);
    }
}
