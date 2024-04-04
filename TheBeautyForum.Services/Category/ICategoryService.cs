using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Services.Category
{
    /// <summary>
    /// Provides access to categories.
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// Deletes category by ID.
        /// </summary>
        /// <param name="categoryId">the ID of the category</param>
        Task DeleteCategoryAsync(Guid categoryId);

        /// <summary>
        /// Creates category.
        /// </summary>
        /// <param name="model">the model for creating the category</param>
        Task CreateCategoryAsync(CategoryViewModel model);

        /// <summary>
        /// Loads all studio categories.
        /// </summary>
        /// <param name="studioId">the ID of the studio</param>
        /// <returns>List of categories.</returns>
        Task<List<CategoryViewModel>> LoadCategoriesAsync(Guid? studioId = null);
    }
}
