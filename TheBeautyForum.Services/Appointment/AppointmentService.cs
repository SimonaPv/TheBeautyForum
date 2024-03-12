using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Services.Appointment
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _dbContext;

        public AppointmentService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task CreateAppointmentAsync(CreateAppointmentViewModel model, Guid studioId, Guid userId)
        {
            var studio = await _dbContext.Studios.FindAsync(studioId);

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
                EndDate = model.EndDate,
                Description = model.Description,
                CategoryId = model.CategoryId
            };

            await _dbContext.Appointments.AddAsync(appointment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<CreateAppointmentViewModel> LoadCategoriesAsync(Guid studioId)
        {
            var studio = await _dbContext.Studios.FindAsync(studioId);

            if (studio == null)
            {
                throw new ArgumentNullException(nameof(studio));
            }

            var categories = await _dbContext.StudioCategories
                .Where(s => s.StudioId == studio.Id)
                .Select(x => new CategoryViewModel()
                {
                    Id = x.CategoryId,
                    Name = x.Category!.Name
                }).ToListAsync();

            var appointment = new CreateAppointmentViewModel()
            {
                StudioId = studio.Id,
                StudioOpenTime = studio.OpenTime,
                StudioCloseTime = studio.CloseTime,
                StudioPfp = studio.StudioPictureUrl,
                Categories = categories
            };

            return appointment;
        }
    }
}
