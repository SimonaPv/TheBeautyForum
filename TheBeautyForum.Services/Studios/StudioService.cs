using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Category;
using TheBeautyForum.Web.ViewModels.Publication;
using TheBeautyForum.Web.ViewModels.Studio;
using static TheBeautyForum.Data.DataConstants;

namespace TheBeautyForum.Services.Studios
{
    public class StudioService : IStudioService
    {
        private readonly ApplicationDbContext _dbContext;

        public StudioService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task EditStudioProfileAsync(EditStudioProfileViewModel model, Guid studioId)
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

            var categories = await this._dbContext.StudioCategories
                .Where(s => s.StudioId == studio.Id)
                .ToListAsync();

            this._dbContext.StudioCategories.RemoveRange(categories);

            foreach (var categoryId in model.CategoryIds)
            {
                var studioCategory = new StudioCategory()
                {
                    StudioId = studio.Id,
                    CategoryId = categoryId
                };

                await this._dbContext.StudioCategories.AddAsync(studioCategory);
            }

            await this._dbContext.SaveChangesAsync();
        }

        public async Task<AllStudiosViewModel> FilterByLocationAsync(string loc)
        {
            if (loc == "all")
            {
                var allStudios = await GetAllStudiosAsync();

                return allStudios;
            }

            #region GetStudiosFromDb

            var model = await _dbContext.Studios
               .Include(x => x.StudioCategories)
               .Include(x => x.Ratings)
               .Select(s => new ViewStudioViewModel()
               {
                   Id = s.Id,
                   Name = s.Name,
                   Description = s.Description,
                   ProfilePictureUrl = s.StudioPictureUrl,
                   Location = s.Location,
                   OpenTime = s.OpenTime.ToString(),
                   CloseTime = s.CloseTime.ToString(),
                   RatingSum = s.Ratings.Average(x => x.Value),
                   Categories = s.StudioCategories.Select(x => new CategoryViewModel()
                   {
                       Id = x.CategoryId,
                       Name = x.Category!.Name
                   }).ToList()
               })
               .Where(x => x.Location.Contains(loc))
               .ToListAsync();

            foreach (var l in model)
            {
                string add = l.Location;
                string[] parts = add.Split(',');
                string result = string.Join(",", parts[0], parts[1]);

                l.Location = result;
            }
            #endregion

            #region MakeThemAllStudiosViewModel

            var studios = new AllStudiosViewModel()
            {
                Studios = model,
                Locations = await _dbContext.Studios.Select(x => x.Location).Distinct().ToListAsync(),
                Categories = await _dbContext.Categories.Select(x => new CategoryViewModel()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync()
            };

            var locs = new List<string>();

            foreach (var l in studios.Locations)
            {
                string add = l;
                string[] parts = add.Split(',');
                string result = string.Join(",", parts[0], parts[1]);

                locs.Add(result);
            }

            studios.Locations = locs.Distinct().ToList();
            #endregion

            return studios;
        }

        public async Task<AllStudiosViewModel> FilterByProcedureAsync(string proc)
        {
            if (proc == "all")
            {
                var allStudios = await GetAllStudiosAsync();

                return allStudios;
            }

            #region GetStudiosFromDb
            var model = await _dbContext.Studios
               .Include(x => x.StudioCategories)
               .Include(x => x.Ratings)
               .Where(x => x.StudioCategories.Select(x => x.Category.Name).Contains(proc))
               .Select(s => new ViewStudioViewModel()
               {
                   Id = s.Id,
                   Name = s.Name,
                   Description = s.Description,
                   ProfilePictureUrl = s.StudioPictureUrl,
                   Location = s.Location,
                   OpenTime = s.OpenTime.ToString(),
                   CloseTime = s.CloseTime.ToString(),
                   RatingSum = s.Ratings.Average(x => x.Value),
                   Categories = s.StudioCategories
                        .Select(x => new CategoryViewModel()
                        {
                            Id = x.CategoryId,
                            Name = x.Category!.Name
                        }).ToList()
               })
               .ToListAsync();

            foreach (var l in model)
            {
                string add = l.Location;
                string[] parts = add.Split(',');
                string result = string.Join(",", parts[0], parts[1]);

                l.Location = result;
            }
            #endregion

            #region MakeThemAllStudiosViewModel
            var studios = new AllStudiosViewModel()
            {
                Studios = model,
                Locations = await _dbContext.Studios.Select(x => x.Location).Distinct().ToListAsync(),
                Categories = await _dbContext.Categories.Select(x => new CategoryViewModel()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync()
            };

            var locs = new List<string>();

            foreach (var l in studios.Locations)
            {
                string add = l;
                string[] parts = add.Split(',');
                string result = string.Join(",", parts[0], parts[1]);

                locs.Add(result);
            }

            studios.Locations = locs.Distinct().ToList();
            #endregion

            return studios;
        }

        public async Task<AllStudiosViewModel> FilterByRatingAsync(string method)
        {
            if (method == "all")
            {
                var allStudios = await GetAllStudiosAsync();

                return allStudios;
            }

            #region GetStudiosFromDb

            var model = await _dbContext.Studios
               .Include(x => x.StudioCategories)
               .Include(x => x.Ratings)
               .Select(s => new ViewStudioViewModel()
               {
                   Id = s.Id,
                   Name = s.Name,
                   Description = s.Description,
                   ProfilePictureUrl = s.StudioPictureUrl,
                   Location = s.Location,
                   OpenTime = s.OpenTime.ToString(),
                   CloseTime = s.CloseTime.ToString(),
                   RatingSum = s.Ratings.Average(x => x.Value),
                   Categories = s.StudioCategories.Select(x => new CategoryViewModel()
                   {
                       Id = x.CategoryId,
                       Name = x.Category!.Name
                   }).ToList()
               }).ToListAsync();

            foreach (var l in model)
            {
                string add = l.Location;
                string[] parts = add.Split(',');
                string result = string.Join(",", parts[0], parts[1]);

                l.Location = result;
            }
            #endregion

            if (method == "ascending")
            {
                model = model.OrderBy(x => x.RatingSum).ToList();
            }
            else
            {
                model = model.OrderByDescending(x => x.RatingSum).ToList();
            }

            #region MakeThemAllStudiosViewModel
            var studios = new AllStudiosViewModel()
            {
                Studios = model,
                Locations = await _dbContext.Studios.Select(x => x.Location).Distinct().ToListAsync(),
                Categories = await _dbContext.Categories.Select(x => new CategoryViewModel()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync()
            };

            var locs = new List<string>();

            foreach (var l in studios.Locations)
            {
                string add = l;
                string[] parts = add.Split(',');
                string result = string.Join(",", parts[0], parts[1]);

                locs.Add(result);
            }

            studios.Locations = locs.Distinct().ToList();
            #endregion

            return studios;
        }

        public async Task<AllStudiosViewModel> GetAllStudiosAsync()
        {
            #region GetStudiosFromDb
            var model = await _dbContext.Studios
                .Include(x => x.StudioCategories)
                .Include(x => x.Ratings)
                .Select(s => new ViewStudioViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    ProfilePictureUrl = s.StudioPictureUrl,
                    Location = s.Location,
                    OpenTime = s.OpenTime.ToString(),
                    CloseTime = s.CloseTime.ToString(),
                    RatingSum = s.Ratings.Sum(x => x.Value),
                    Categories = s.StudioCategories.Select(x => new CategoryViewModel()
                    {
                        Id = x.CategoryId,
                        Name = x.Category!.Name
                    }).ToList()
                }).ToListAsync();

            foreach (var l in model)
            {
                string add = l.Location;
                string[] parts = add.Split(',');
                string result = string.Join(",", parts[0], parts[1]);

                l.Location = result;
            }
            #endregion

            #region MakeThemAllStudiosViewModel
            var studios = new AllStudiosViewModel()
            {
                Studios = model,
                Locations = await _dbContext.Studios.Select(x => x.Location).Distinct().ToListAsync(),
                Categories = await _dbContext.Categories.Select(x => new CategoryViewModel()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync()
            };

            var locs = new List<string>();

            foreach (var l in studios.Locations)
            {
                string add = l;
                string[] parts = add.Split(',');
                string result = string.Join(",", parts[0], parts[1]);

                locs.Add(result);
            }

            studios.Locations = locs.Distinct().ToList();
            #endregion

            return studios;
        }

        public async Task<EditStudioProfileViewModel> GetStudioAsync(Guid studioId)
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
                Categories = categories
            };

            return model;
        }

        public async Task<StudioProfileViewModel> ShowStudioProfileAsync(Guid studioId)
        {
            var appointments = await _dbContext.Appointments
               .Where(d => d.StartDate < DateTime.Now)
               .ToListAsync();

            _dbContext.RemoveRange(appointments);
            await _dbContext.SaveChangesAsync();

            var model = await _dbContext.Studios
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
                Name = model.Name,
                ProfilePictureUrl = model.StudioPictureUrl,
                RatingSum = model.Ratings.Sum(x => x.Value),
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
                            StudioName = p.Studio.Name
                        })
                        .ToListAsync(),
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
                    .ToListAsync(),
            };

            return profile;
        }
    }
}
