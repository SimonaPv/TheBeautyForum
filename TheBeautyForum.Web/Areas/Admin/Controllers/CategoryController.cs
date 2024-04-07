using Microsoft.AspNetCore.Mvc;
using TheBeautyForum.Services.Category;
using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// Represents the category controller.
    /// </summary>
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;

        /// <summary>
        /// Initialize new instance of <see cref="CategoryController"/> class.
        /// </summary>
        /// <param name="categoryService"></param>
        public CategoryController(
            ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        /// <summary>
        /// Creates category.
        /// </summary>
        /// <returns>The view "Create"</returns>
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Creates category.
        /// </summary>
        /// <param name="model">the model for creating the category</param>
        /// <returns>The view "LoggedProfile"</returns>
        [HttpPost]
        public async Task<IActionResult> Create(
            CategoryViewModel model)
        {
            try
            {
                await _categoryService.CreateCategoryAsync(model);

                return RedirectToAction("LoggedProfile", "User");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes category.
        /// </summary>
        /// <param name="id">the ID of the category that has to be deleted</param>
        /// <returns>The view "LoggedProfile"</returns>
        public async Task<IActionResult> Delete(
            [FromRoute]
            Guid id)
        {
            try
            {
                await _categoryService.DeleteCategoryAsync(id);

                return RedirectToAction("LoggedProfile", "User");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
