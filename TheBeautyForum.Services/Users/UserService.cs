using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Category;
using TheBeautyForum.Web.ViewModels.Publication;
using TheBeautyForum.Web.ViewModels.Rating;
using TheBeautyForum.Web.ViewModels.Studio;
using TheBeautyForum.Web.ViewModels.User;

namespace TheBeautyForum.Services.Users
{
    /// <summary>
    /// Represents an user service.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _dbContext;

        /// <summary>
        /// Initialize a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public UserService(
            ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        /// <inheritdoc/>
        public async Task ApproveStudioAsync(
            Guid studioId)
        {
            var model = await _dbContext.Studios
                .FirstOrDefaultAsync(x => x.Id == studioId);

            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            model.IsApproved = true;
            await _dbContext.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task DeclineStudioAsync(Guid studioId)
        {
            var model = await _dbContext.Studios
                .FirstOrDefaultAsync(x => x.Id == studioId);

            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            _dbContext.Studios.Remove(model);
            await _dbContext.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task EditUserProfileAsync(
            EditProfileViewModel model, 
            Guid userId)
        {
            var user = await _dbContext.Users.FindAsync(userId);

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.NormalizedEmail = model.Email.ToUpper();
            user.UserName = model.FirstName;
            user.NormalizedUserName = model.FirstName.ToUpper();

            await _dbContext.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task<EditProfileViewModel> GetUserAsync(
            Guid userId)
        {
            var model = await _dbContext.Users.FindAsync(userId);

            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var user = new EditProfileViewModel()
            {
                Id = model.Id,
                ProfilePictureUrl = model.ProfilePictureUrl,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            };

            return user;
        }

        /// <inheritdoc/>
        public async Task<ProfileViewModel> ShowAdminProfileAsync(
            Guid userId)
        {
            var user = await _dbContext.Users
               .Include(a => a.Appointments)
               .Include(r => r.Ratings)
               .Include(p => p.Publications)
               .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var profile = new ProfileViewModel()
            {
                UserId = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ProfilePictureUrl = user.ProfilePictureUrl,
                Email = user.Email,

                Appointments = await _dbContext.Appointments
                    .Include(c => c.Category)
                    .Include(s => s.Studio)
                    .Select(a => new AppointmentViewModel()
                    {
                        Id = a.Id,
                        UserId = a.UserId,
                        StudioId = a.StudioId,
                        StartDate = a.StartDate,
                        EndDate = a.EndDate,
                        Description = a.Description,
                        CategoryName = a.Category!.Name,
                        StudioName = a.Studio!.Name,
                        UserName = a.User.FirstName
                    })
                    .ToListAsync(),
                Users = await _dbContext.Users
                    .Select(u => new UserViewModel()
                    {
                        Id = u.Id,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        ProfilePictureUrl = u.ProfilePictureUrl,
                        Email = u.Email,
                        Role = u.UserRole
                    }).ToListAsync(),
                FavoriteStudios = await _dbContext.Studios
                    .Where(x => x.IsApproved == false)
                    .Select(x => new StudioUserViewModel()
                    {
                        StudioId = x.Id,
                        StudioDescription = x.Description,
                        StudioName = x.Name,
                        ProfilePicUrl = x.StudioPictureUrl
                    }).ToListAsync(),
                Categories = await _dbContext.Categories
                    .Select(x => new CategoryViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToListAsync()
            };

            return profile;
        }

        /// <inheritdoc/>
        public async Task<ProfileViewModel> ShowLoggedProfileAsync(
            Guid userId)
        {
            var user = await _dbContext.Users
                .Include(a => a.Appointments)
                .Include(r => r.Ratings)
                .Include(p => p.Publications)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var profile = new ProfileViewModel()
            {
                UserId = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ProfilePictureUrl = user.ProfilePictureUrl,
                Email = user.Email,
                Ratings = user.Ratings
                        .Select(r => new RatingViewModel()
                        {
                            Id = r.Id,
                            UserId = r.UserId,
                            StudioId = r.StudioId,
                            Value = r.Value
                        })
                        .ToList(),
                Publications = await _dbContext.Publications
                        .Include(x => x.Studio)
                        .Include(x => x.Image)
                        .Where(x => x.UserId == userId)
                        .Select(p => new Web.ViewModels.Publication.PostForumViewModel()
                        {
                            Id = p.Id,
                            UserId = p.UserId,
                            StudioId = p.StudioId,
                            StudioName = p.Studio.Name,
                            Description = p.Description,
                            ImageUrl = _dbContext.Images.Where(x => x.PublicationId == p.Id).Select(x => x.UrlPath).First(),
                            DatePosted = p.DatePosted,
                            LikeCount = p.Likes.Count
                        })
                        .ToListAsync(),
                Images = await _dbContext.Images
                    .Where(x => x.Publication!.UserId == userId)
                    .Select(x => x.UrlPath!)
                    .ToListAsync(),
                Appointments = await _dbContext.Appointments
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
                    StudioName = a.Studio!.Name,
                    Rating = _dbContext.Ratings
                         .Select(x => new RatingViewModel()
                         {
                             Id = x.Id,
                             Value = x.Value,
                             UserId = x.UserId,
                             StudioId = x.StudioId
                         })
                        .FirstOrDefault(x => x.UserId == userId && x.StudioId == a.StudioId)
                })
                .ToListAsync(),
                Post = new CreatePublicationViewModel()
                {
                    Studios = _dbContext.Studios
                            .Select(s => new StudioPostViewModel()
                            {
                                Id = s.Id,
                                StudioName = s.Name
                            }).ToList(),
                    UserFirstName = user.FirstName,
                    UserLastName = user.LastName,
                    UserProfilePic = user.ProfilePictureUrl,
                    ViewUrl = "LoggedProfile",
                }
            };

            var publicationIds = profile.Publications.Select(f => f.Id);
            var likes = _dbContext.Likes
                    .Where(l => l.UserId == userId && publicationIds.Contains(l.PublicationId));

            profile.Publications
                .ForEach(f => f.PostLikedByCurrentUser = likes.FirstOrDefault(p => p.UserId == userId && p.PublicationId == f.Id) != null);

            return profile;
        }

        /// <inheritdoc/>
        public async Task<ProfileViewModel> ShowStudioCreatorLoggedProfileAsync(
            Guid userId)
        {
            var user = await _dbContext.Users
               .Include(x => x.Studios)
               .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var profile = new ProfileViewModel()
            {
                UserId = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ProfilePictureUrl = user.ProfilePictureUrl,
                Email = user.Email,
                FavoriteStudios = await _dbContext.Studios
                    .Include(x => x.Ratings)
                    .Where(s => s.UserId == userId)
                    .Select(x => new StudioUserViewModel()
                    {
                        StudioId = x.Id,
                        StudioName = x.Name,
                        StudioDescription = x.Description,
                        ProfilePicUrl = x.StudioPictureUrl,
                        IsApproved = x.IsApproved,
                        RatingSum = x.Ratings.Count > 0 ? (int)Math.Round(x.Ratings.Average(x => x.Value), 0, MidpointRounding.AwayFromZero) : 0,
                    }).ToListAsync(),
            };

            return profile;
        }

        /// <inheritdoc/>
        public async Task<ProfileViewModel> ShowUserProfileAsync(
            Guid userId, 
            Guid loggedUserId)
        {
            var user = await _dbContext.Users
                .Include(a => a.Appointments)
                .Include(r => r.Ratings)
                .Include(p => p.Publications)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var pubs = await _dbContext.Publications
               .Include(x => x.Image)
               .Where(x => x.UserId == userId)
               .Select(x => new StudioUserViewModel()
               {
                   StudioId = x.StudioId,
                   StudioName = x.Studio.Name,
                   ProfilePicUrl = x.Studio.StudioPictureUrl,
                   StudioDescription = x.Studio.Description,
               }).ToListAsync();

            var apps = await _dbContext.Appointments
                .Where(x => x.UserId == userId)
                .Select(x => new StudioUserViewModel()
                {
                    StudioId = x.StudioId,
                    StudioName = x.Studio.Name,
                    ProfilePicUrl = x.Studio.StudioPictureUrl,
                    StudioDescription = x.Studio.Description,
                }).ToListAsync();

            pubs.AddRange(apps);

            var profile = new ProfileViewModel()
            {
                UserId = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ProfilePictureUrl = user.ProfilePictureUrl,
                Email = user.Email,
                Ratings = user.Ratings
                        .Select(r => new RatingViewModel()
                        {
                            Id = r.Id,
                            UserId = r.UserId,
                            StudioId = r.StudioId,
                            Value = r.Value
                        })
                        .ToList(),
                Publications = await _dbContext.Publications
                        .Include(x => x.Studio)
                        .Include(x => x.Image)
                        .Where(x => x.UserId == userId)
                        .Select(p => new Web.ViewModels.Publication.PostForumViewModel()
                        {
                            Id = p.Id,
                            UserId = p.UserId,
                            StudioId = p.StudioId,
                            StudioName = p.Studio.Name,
                            Description = p.Description,
                            ImageUrl = p.Image.UrlPath,
                            DatePosted = p.DatePosted,
                            LikeCount = p.Likes.Count
                        })
                        .ToListAsync(),
                Images = await _dbContext.Images
                    .Where(x => x.Publication!.UserId == userId)
                    .Select(x => x.UrlPath!)
                    .ToListAsync(),
                FavoriteStudios = pubs.DistinctBy(x => x.StudioName).ToList(),
                Appointments = await _dbContext.Appointments
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
                        StudioName = a.Studio!.Name,
                    })
                    .ToListAsync(),
            };

            var publicationIds = profile.Publications.Select(f => f.Id);
            var likes = _dbContext.Likes
                    .Where(like => like.UserId == loggedUserId && publicationIds.Contains(like.PublicationId));

            profile.Publications.ForEach(f => f.PostLikedByCurrentUser = likes.FirstOrDefault(publication => publication.UserId == loggedUserId && publication.PublicationId == f.Id) != null);

            return profile;
        }
    }
}
