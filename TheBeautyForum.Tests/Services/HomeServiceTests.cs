using TheBeautyForum.Data.Models;
using TheBeautyForum.Services.Home;
using TheBeautyForum.Tests.Mocks;
using TheBeautyForum.Web.ViewModels.Home;

namespace TheBeautyForum.Tests.Services
{
    [TestFixture]
    public class HomeServiceTests
    {
        [Test]
        public async Task LoadAllCategories_ReturnAllCategories()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            data.Users.Add(new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "test",
                LastName = "test",
                UserRole = "test"
            });

            data.Studios.Add(new Studio()
            {
                Id = Guid.NewGuid(),
                Description = "test",
                Location = "test",
                Name = "test",
            });

            data.SaveChanges();

            var homeService = new HomeService(data);

            #endregion

            #region Act

            var result = await homeService.HomeAsync();

            #endregion

            #region Assert

            Assert.That(result.UsersCount, Is.EqualTo(data.Users.Count() + 200));
            Assert.That(result.StudiosCount, Is.EqualTo(data.Studios.Count() + 100));
            Assert.That(result, Is.TypeOf<HomeViewModel>());

            #endregion
        }
    }
}
