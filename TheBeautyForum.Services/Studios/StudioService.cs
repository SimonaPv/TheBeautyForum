﻿using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Services.Category;
using TheBeautyForum.Services.Images;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Category;
using TheBeautyForum.Web.ViewModels.Publication;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Services.Studios
{
    /// <summary>
    /// Represents an studio service.
    /// </summary>
    public class StudioService : IStudioService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IImageService _imageService;
        private readonly ICategoryService _categoryService;

        /// <summary>
        /// Initialize a new instance of the <see cref="StudioService"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="imageService"></param>
        /// <param name="categoryService"></param>
        public StudioService(
            ApplicationDbContext dbContext,
            IImageService imageService,
            ICategoryService categoryService)
        {
            this._dbContext = dbContext;
            this._imageService = imageService;
            this._categoryService = categoryService;
        }

        /// <inheritdoc/>
        public async Task<CreateStudioViewModel> CreateStudioCategoriesAsync()
        {
            var model = new CreateStudioViewModel()
            {
                Categories = await _categoryService.LoadCategoriesAsync(),
            };

            return model;
        }

        /// <inheritdoc/>
        public async Task CreateStudioAsync(
            CreateStudioViewModel model,
            Guid userId)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var studio = new Data.Models.Studio()
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                Name = model.Name,
                Description = model.Description,
                Location = model.Location,
                OpenTime = TimeOnly.Parse(model.OpenTime),
                CloseTime = TimeOnly.Parse(model.CloseTime),
            };

            if (model.ProfilePicture == null)
            {
                studio.StudioPictureUrl = "https://res.cloudinary.com/di1lcwb4r/image/upload/v1714415949/hw1ae4bawkxxafpphzxk.jpg";
            }

            await _dbContext.Studios.AddAsync(studio);

            foreach (var categoryId in model.CategoryIds)
            {
                var categoryStudio = new StudioCategory()
                {
                    StudioId = studio.Id,
                    CategoryId = categoryId
                };

                await _dbContext.StudiosCategories.AddAsync(categoryStudio);
            }

            await _dbContext.SaveChangesAsync();

            if (model.ProfilePicture != null)
            {
                await this._imageService.UploadImage(model.ProfilePicture, "images", studio);
            }
        }

        /// <inheritdoc/>
        public async Task DeleteStudioAsync(
            Guid studioId)
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
        public async Task EditStudioProfileAsync(
            EditStudioProfileViewModel model,
            Guid studioId)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var studio = await this._dbContext.Studios
                .FindAsync(studioId);

            if (studio is null)
            {
                throw new ArgumentNullException(nameof(studio));
            }

            studio.Name = model.Name;
            studio.Description = model.Description;
            studio.Location = model.Location;
            studio.OpenTime = TimeOnly.Parse(model.OpenTime);
            studio.CloseTime = TimeOnly.Parse(model.CloseTime);

            if (model.CategoryIds.Count > 0)
            {
                var categories = await this._dbContext.StudiosCategories
                    .Where(s => s.StudioId == studio.Id)
                    .ToListAsync();

                this._dbContext.StudiosCategories.RemoveRange(categories);

                foreach (var categoryId in model.CategoryIds)
                {
                    var studioCategory = new StudioCategory()
                    {
                        StudioId = studio.Id,
                        CategoryId = categoryId
                    };

                    await this._dbContext.StudiosCategories.AddAsync(studioCategory);
                }
            }

            await this._dbContext.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task<List<ViewStudioViewModel>> GetAllStudiosAsync(
            FilterViewModel? filter = null)
        {
            var studios = await _dbContext.Studios
                .Include(x => x.StudioCategories)
                .Include(x => x.Ratings)
                .Where(x => x.IsApproved == true)
                .Select(s => new ViewStudioViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    ProfilePictureUrl = s.StudioPictureUrl,
                    Location = s.Location,
                    OpenTime = s.OpenTime.ToString(),
                    CloseTime = s.CloseTime.ToString(),
                    RatingSum = s.Ratings.Count > 0 ? (int)Math.Round(s.Ratings.Average(x => x.Value), 0, MidpointRounding.AwayFromZero) : 0,
                    Categories = s.StudioCategories.Select(x => new CategoryViewModel()
                    {
                        Id = x.CategoryId,
                        Name = x.Category!.Name
                    }).ToList(),
                }).ToListAsync();

            foreach (var s in studios)
            {
                string add = s.Location;
                string[] parts = add.Split(',');
                string result = string.Join(",", parts[0], parts[1]);

                s.Location = result;
            }

            var locations = studios.Select(x => x.Location).Distinct().ToList();
            var categories = new List<CategoryViewModel>();

            foreach (var m in studios)
            {
                categories.AddRange(m.Categories);
            }

            categories = categories.Distinct().ToList();

            if (filter.Location != null && filter.Category != null && filter.Rating != null)
            {
                if (filter.Location != "none")
                {
                    studios = studios.Where(x => x.Location == filter.Location).ToList();
                }
                if (filter.Category != "none")
                {
                    studios = studios.Where(x => x.Categories.Select(x => x.Name).Contains(filter.Category)).ToList();
                }
                if (filter.Rating != "none")
                {
                    if (filter.Rating == "descending")
                    {
                        studios = studios.OrderByDescending(x => x.RatingSum).ToList();
                    }
                    else
                    {
                        studios = studios.OrderBy(x => x.RatingSum).ToList();
                    }
                }
            }

            studios[0].Filter = new FilterViewModel()
            {
                Locations = locations,
                Categories = categories,
                Location = filter.Location,
                Category = filter.Category,
                Rating = filter.Rating,
            };

            return studios;
        }

        /// <inheritdoc/>
        public async Task<EditStudioProfileViewModel> GetStudioAsync(
            Guid studioId)
        {
            var studio = await _dbContext.Studios
                .Include(sc => sc.StudioCategories)
                .Include(r => r.Ratings)
                .FirstOrDefaultAsync(s => s.Id == studioId);

            if (studio is null)
            {
                throw new ArgumentNullException(nameof(studio));
            }

            var categories = await _dbContext.Categories
                .Select(x => new CategoryViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsSelected = false
                })
                .OrderBy(x => x.Name)
                .ToListAsync();

            foreach (var cat in categories)
            {
                if (studio.StudioCategories.Select(x => x.CategoryId).Contains(cat.Id))
                {
                    cat.IsSelected = true;
                }
            }

            var model = new EditStudioProfileViewModel()
            {
                Id = studio.Id,
                Name = studio.Name,
                Description = studio.Description,
                ProfilePictureUrl = studio.StudioPictureUrl,
                Location = studio.Location,
                OpenTime = studio.OpenTime.ToString(),
                CloseTime = studio.CloseTime.ToString(),
                Categories = categories,
                CategoryIds = categories.Where(x => x.IsSelected == true).Select(x => x.Id).ToList(),
            };

            return model;
        }

        public async Task<StudioProfileViewModel> ShowStudioProfileAsync(
            Guid studioId,
            Guid userId)
        {
            var model = await _dbContext.Studios
                .Include(x => x.User)
                .Include(x => x.Ratings)
                .Include(x => x.Publications)
                .Include(x => x.Appointments)
                .Include(x => x.StudioCategories)
                .FirstOrDefaultAsync(s => s.Id == studioId);

            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var profile = new StudioProfileViewModel()
            {
                StudioId = model.Id,
                UserId = model.User.Id,
                Name = model.Name,
                ProfilePictureUrl = model.StudioPictureUrl,
                RatingSum = model.Ratings.Count > 0 ? (int)Math.Round(model.Ratings.Average(x => x.Value), 0, MidpointRounding.AwayFromZero) : 0,
                Location = model.Location,
                Description = model.Description,
                OpenTime = model.OpenTime,
                CloseTime = model.CloseTime,
                Publications = await _dbContext.Publications
                        .Where(x => x.StudioId == model.Id)
                        .Select(p => new PostForumViewModel()
                        {
                            Id = p.Id,
                            UserId = p.UserId,
                            StudioId = p.StudioId,
                            Description = p.Description,
                            ImageUrl = _dbContext.Images.Where(x => x.PublicationId == p.Id).Select(x => x.UrlPath!).FirstOrDefault(),
                            DatePosted = p.DatePosted,
                            UserName = $"{p.User.FirstName} {p.User.LastName}",
                            ProfilePicUrl = p.User.ProfilePictureUrl,
                            StudioName = p.Studio.Name,
                            LikeCount = p.Likes.Count
                        })
                        .ToListAsync(),
                CategoryNames = await _dbContext.StudiosCategories
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
                    .ToListAsync(),
            };

            var publicationIds = profile.Publications
                .Select(f => f.Id);
            var likes = _dbContext.Likes
                    .Where(l => l.UserId == userId && publicationIds.Contains(l.PublicationId));

            profile.Publications
                .ForEach(f => f.PostLikedByCurrentUser = likes.FirstOrDefault(p => p.UserId == userId && p.PublicationId == f.Id) != null);

            return profile;
        }
    }
}
