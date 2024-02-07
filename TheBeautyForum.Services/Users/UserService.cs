using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Rating;
using TheBeautyForum.Web.ViewModels.User;

namespace TheBeautyForum.Services.Users
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<ProfileViewModel> ShowProfileAsync(Guid userId)
        {
            var model = await _dbContext.Users
                .Include(a => a.Appointments)
                .Include(r => r.Ratings)
                .Include(p => p.Publications)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var profile = new ProfileViewModel()
            {
                UserId = model.Id,
                User = new UserViewModel()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    ProfilePictureUrl = model.ProfilePictureUrl,
                    Email = model.Email,
                    Ratings = model.Ratings
                        .Select(r => new RatingViewModel()
                        {
                            Id = r.Id,
                            UserId = r.UserId,
                            StudioId = r.StudioId,
                            Value = r.Value
                        })
                        .ToList(),
                    Publications = model.Publications
                        .Select(p => new Web.ViewModels.Publication.PostForumViewModel()
                        {
                            Id = p.Id,
                            UserId = p.UserId,
                            StudioId = p.StudioId,
                            Description = p.Description,
                            ImageUrls = _dbContext.Images.Where(x => x.PublicationId == p.Id).Select(x => x.UrlPath!).ToList()
                        })
                        .ToList()
                },
                Images = await _dbContext.Images
                    .Where(x => x.Publication!.UserId == userId)
                    .Select(x => x.UrlPath!)
                    .ToListAsync()
            };

            profile.User.Appointments = await _dbContext.Appointments
                .Include(c => c.Category)
                .Include(s => s.Studio)
                .Where(u => u.UserId == userId)
                .Select(a => new AppointmentViewModel()
                {
                    Id = a.Id,
                    UserId = a.UserId,
                    StudioId = a.StudioId,
                    StartDate = a.StartDate,
                    EndDate = a.EndDate,
                    Description = a.Description,
                    CategoryName = a.Category!.Name,
                    StudioName = a.Studio!.Name
                })
                .ToListAsync();

            return profile;
        }
    }
}
