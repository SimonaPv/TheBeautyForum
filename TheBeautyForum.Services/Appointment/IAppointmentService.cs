﻿using TheBeautyForum.Web.ViewModels.Appointment;

namespace TheBeautyForum.Services.Appointment
{
    public interface IAppointmentService
    {
        Task CreateAppointmentAsync(CreateAppointmentViewModel model, Guid studioId, Guid userId);

        Task<CreateAppointmentViewModel> LoadCategoriesAsync(Guid studioId);
    }
}