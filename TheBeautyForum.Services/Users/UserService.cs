﻿using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Rating;
using TheBeautyForum.Web.ViewModels.Studio;
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

        public async Task<ProfileViewModel> ShowLoggedProfileAsync(Guid userId)
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
                Publications = await _dbContext.Publications
                        .Include(x => x.Studio)
                        .Where(x => x.UserId == userId)
                        .Select(p => new Web.ViewModels.Publication.PostForumViewModel()
                        {
                            Id = p.Id,
                            UserId = p.UserId,
                            StudioId = p.StudioId,
                            StudioName = p.Studio.Name,
                            Description = p.Description,
                            ImageUrls = _dbContext.Images.Where(x => x.PublicationId == p.Id).Select(x => x.UrlPath!).ToList(),
                            DatePosted = p.DatePosted
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
                    StudioName = a.Studio!.Name
                })
                .ToListAsync()
            };

            return profile;
        }

        public async Task<ProfileViewModel> ShowUserProfileAsync(Guid userId)
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

            var pubs = await _dbContext.Publications
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
                UserId = model.Id,
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
                Publications = await _dbContext.Publications
                        .Include(x => x.Studio)
                        .Where(x => x.UserId == userId)
                        .Select(p => new Web.ViewModels.Publication.PostForumViewModel()
                        {
                            Id = p.Id,
                            UserId = p.UserId,
                            StudioId = p.StudioId,
                            StudioName = p.Studio.Name,
                            Description = p.Description,
                            ImageUrls = _dbContext.Images.Where(x => x.PublicationId == p.Id).Select(x => x.UrlPath!).ToList(),
                            DatePosted = p.DatePosted
                        })
                        .ToListAsync(),
                Images = await _dbContext.Images
                    .Where(x => x.Publication!.UserId == userId)
                    .Select(x => x.UrlPath!)
                    .ToListAsync(),
                FavoriteStudios = pubs.DistinctBy(x => x.StudioName).ToList(),
            };

            return profile;
        }
    }
}