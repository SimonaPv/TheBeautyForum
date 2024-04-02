using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Services.Appointment
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _dbContext;

        public AppointmentService(
            ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task CreateAppointmentAsync(
            CreateAppointmentViewModel model, 
            Guid studioId, 
            Guid userId)
        {
            var studio = await _dbContext.Studios
                .FindAsync(studioId);

            if (studio == null)
            {
                throw new ArgumentNullException(nameof(studio));
            }

            var appointment = new TheBeautyForum.Data.Models.Appointment()
            {
                Id = Guid.NewGuid(),
                StudioId = studioId,
                UserId = userId,
                StartDate = model.StartDate,
                EndDate = model.StartDate.AddHours(1),
                Description = model.Description,
                CategoryId = model.CategoryId
            };

            await _dbContext.Appointments.AddAsync(appointment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<CreateAppointmentViewModel> GetAppointmentAsync(
            Guid appointmentId)
        {
            var model = await this._dbContext.Appointments
                .Include(s => s.Studio)
                .Include(u => u.User)
                .Include(c => c.Category)
                .FirstOrDefaultAsync(x => x.Id == appointmentId);

            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            
            var sth = await LoadCategoriesAsync(model.StudioId);
            sth.Id = appointmentId;
            sth.Description = model.Description;
            sth.CategoryId = model.CategoryId;
            sth.EndDate = model.EndDate;
            sth.StartDate = model.StartDate;
            sth.StartDateHour = model.StartDate.Hour;

            return sth;
        }

        public async Task DeleteAppointmentAsync(
            Guid appointmentId)
        {
            var model = await _dbContext.Appointments
                .FirstOrDefaultAsync(x => x.Id == appointmentId);

            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            _dbContext.Remove(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditAppointmentAsync(
            Guid appointmentId, 
            Guid userId, 
            CreateAppointmentViewModel model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var appointment = await _dbContext.Appointments
                .FirstOrDefaultAsync(x => x.Id == appointmentId);

            if (appointment is null)
            {
                throw new ArgumentNullException(nameof(appointment));
            }

            appointment.CategoryId = model.CategoryId;
            appointment.StartDate = model.StartDate;
            appointment.EndDate = model.EndDate;
            appointment.Description = model.Description;

            await _dbContext.SaveChangesAsync();
        }

        public async Task<CreateAppointmentViewModel> LoadCategoriesAsync(
            Guid studioId)
        {
            var studio = await _dbContext.Studios.FindAsync(studioId);

            if (studio == null)
            {
                throw new ArgumentNullException(nameof(studio));
            }

            var categories = await _dbContext.StudiosCategories
                .Where(s => s.StudioId == studio.Id)
                .Select(x => new CategoryViewModel()
                {
                    Id = x.CategoryId,
                    Name = x.Category!.Name
                }).ToListAsync();

            var appointment = new CreateAppointmentViewModel()
            {
                StudioId = studio.Id,
                StudioOpenTime = studio.OpenTime.ToString(),
                StudioCloseTime = studio.CloseTime.ToString(),
                StudioPfp = studio.StudioPictureUrl,
                Categories = categories
            };

            return appointment;
        }
    }
}
