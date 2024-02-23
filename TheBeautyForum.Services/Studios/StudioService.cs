using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Services.Studios
{
    public class StudioService : IStudioService
    {
        private readonly ApplicationDbContext _dbContext;

        public StudioService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<StudioProfileViewModel> ShowStudioProfileAsync(Guid studioId)
        {
            var model = await _dbContext.Studios
                .Include(x => x.Ratings)
                .Include(x => x.Publications)
                .Include(x => x.Appointments)
                .Include(x => x.StudioCategories)
                .Include(x => x.StudioCategories)
                .FirstOrDefaultAsync(s => s.Id == studioId);

            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var profile = new StudioProfileViewModel()
            {
                StudioId = model.Id,
                Name = model.Name,
                ProfilePictureUrl = model.StudioPictureUrl,
                RatingSum = model.Ratings.Sum(x => x.Value),
                Location = model.Location,
                Description = model.Description,
                OpenTime = model.OpenTime,
                CloseTime = model.CloseTime,
                Publications = model.Publications
                        .Select(p => new Web.ViewModels.Publication.PostForumViewModel()
                        {
                            Id = p.Id,
                            UserId = p.UserId,
                            StudioId = p.StudioId,
                            Description = p.Description,
                            ImageUrl = _dbContext.Images.Where(x => x.PublicationId == p.Id).Select(x => x.UrlPath!).FirstOrDefault(),
                            DatePosted = p.DatePosted
                        })
                        .ToList(),
                CategoryNames = await _dbContext.StudioCategories
                    .Where(x => x.StudioId == studioId)
                    .Select(x => x.Category!.Name)
                    .ToListAsync(),
                Images = await _dbContext.Images
                    .Where(x => x.Publication!.StudioId == studioId)
                    .Select(x => x.UrlPath!)
                    .ToListAsync(),
                Appointments = await _dbContext.Appointments
                    .Include(c => c.Category)
                    .Include(s => s.Studio)
                    .Where(u => u.StudioId == studioId)
                    .Select(a => new AppointmentViewModel()
                    {
                        Id = a.Id,
                        UserId = a.UserId,
                        UserName = $"{a.User!.FirstName}",
                        StudioId = a.StudioId,
                        StartDate = a.StartDate,
                        EndDate = a.EndDate,
                        Description = a.Description,
                        CategoryName = a.Category!.Name,
                        StudioName = a.Studio!.Name
                    })
                    .ToListAsync()
            };

            return profile;
        }
    }
}
