using Microsoft.AspNetCore.Mvc;
using TheBeautyForum.Services.Category;
using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Web.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel model)
        {
            await _categoryService.CreateCategoryAsync(model);

            return RedirectToAction("LoggedProfile", "User");
        }

        public async Task<IActionResult> Delete(
            [FromRoute]
            Guid id)
        {
            await _categoryService.DeleteCategoryAsync(id);

            return RedirectToAction("LoggedProfile", "User");
        }
    }
}
