using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task CreateCategoryAsync(CategoryViewModel model)
        {
            var category = new Data.Models.Category()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
            };

            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(Guid categoryId)
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
    }
}
