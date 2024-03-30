using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Services.Category
{
    public interface ICategoryService
    {
        Task DeleteCategoryAsync(Guid categoryId);

        Task CreateCategoryAsync(CategoryViewModel model);

        Task<List<CategoryViewModel>> LoadCategoriesAsync();
    }
}
