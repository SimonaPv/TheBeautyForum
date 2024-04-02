using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Services.Category;
using TheBeautyForum.Tests.Mocks;
using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Tests.Services
{
    [TestFixture]
    public class CategoryServiceTests
    {
        [Test]
        public async Task CreateCategory_CorrectRequest()
        {
            #region Arrange

            var data = DatabaseMock.Instance;

            var request = new CategoryViewModel()
            {
                Name = "TestName"
            };

            var categoryService = new CategoryService(data);

            #endregion

            #region Act

            await categoryService.CreateCategoryAsync(request);

            var category = await data.Categories
                .Where(c => c.Name == request.Name)
                .FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(category, Is.Not.Null);

            #endregion
        }

        [Test]
        public async Task CreateCategory_ThrowsIfRequestIsNull()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var categoryService = new CategoryService(data);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await categoryService.CreateCategoryAsync(null));

            #endregion
        }

        [Test]
        public async Task DeleteCategory_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var categoryService = new CategoryService(data);

            var id = Guid.NewGuid();

            data.Categories.Add(new Category()
            {
                Id = id,
                Name = "TestName"
            });

            data.SaveChanges();

            #endregion

            #region Act

            await categoryService.DeleteCategoryAsync(id);

            var categories = await data.Categories.FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(categories, Is.Null);

            #endregion
        }

        [Test]
        public async Task DeleteCategory_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var categoryService = new CategoryService(data);

            var id = Guid.NewGuid();

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
              => await categoryService.DeleteCategoryAsync(id));

            #endregion
        }

        [Test]
        public async Task LoadStudioCategories_ReturnStudioCategories()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var categoryId = Guid.NewGuid();
            var studioId = Guid.NewGuid();

            data.Categories.Add(new Category()
            {
                Name = "NameTest",
            });
            data.Categories.Add(new Category()
            {
                Name = "NameTest2",
            });

            data.SaveChanges();

            data.StudiosCategories.Add(new StudioCategory()
            {
                StudioId = studioId,
                CategoryId = Guid.NewGuid(),
                Category = data.Categories.First(x => x.Name == "NameTest2"),
            });

            data.SaveChanges();

            var categoryService = new CategoryService(data);

            #endregion

            #region Act

            var result = await categoryService.LoadCategoriesAsync(studioId);

            #endregion

            #region Assert

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<CategoryViewModel>>());

            #endregion
        }

        [Test]
        public async Task LoadAllCategories_ReturnAllCategories()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            data.Categories.Add(new Category()
            {
                Name = "NameTest",
            });
            data.Categories.Add(new Category()
            {
                Name = "NameTest2",
            });

            data.SaveChanges();

            var categoryService = new CategoryService(data);

            #endregion

            #region Act

            var result = await categoryService.LoadCategoriesAsync();

            #endregion

            #region Assert

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result, Is.TypeOf<List<CategoryViewModel>>());

            #endregion
        }
    }
}
