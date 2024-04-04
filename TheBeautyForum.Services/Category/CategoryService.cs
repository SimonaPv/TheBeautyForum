using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Services.Category
{
    /// <summary>
    /// Represents an category service.
    /// </summary>
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _dbContext;

        /// <summary>
        /// Initialize a new instance of the <see cref="CategoryService"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public CategoryService(
            ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        /// <inheritdoc/>
        public async Task CreateCategoryAsync(
            CategoryViewModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var category = new Data.Models.Category()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
            };

            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task DeleteCategoryAsync(
            Guid categoryId)
        {
            var model = await _dbContext.Categories
                .FirstOrDefaultAsync(x => x.Id == categoryId);

            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            _dbContext.Categories.Remove(model);
            await _dbContext.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task<List<CategoryViewModel>> LoadCategoriesAsync(
            Guid? studioId = null)
        {
            if (studioId != null)
            {
                var model = await _dbContext.StudiosCategories
                    .Where(x => x.StudioId == studioId)
                    .Select(x => new CategoryViewModel()
                    {
                        Id = x.Category.Id,
                        Name = x.Category.Name,
                        IsSelected = false
                    }).ToListAsync();

                return model;
            }
            else
            {
                var model = await _dbContext.Categories
                    .Select(x => new CategoryViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        IsSelected = false
                    }).ToListAsync();

                return model;
            }
        }
    }
}
