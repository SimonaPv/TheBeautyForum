using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Services.Users;
using TheBeautyForum.Tests.Mocks;
using TheBeautyForum.Web.ViewModels.User;

namespace TheBeautyForum.Tests.Services
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public async Task GetUser_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);
            var userId = Guid.NewGuid();

            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "Test",
                LastName = "Test",
                UserRole = "User"
            });

            data.SaveChanges();

            #endregion

            #region Act

            var result = await userService.GetUserAsync(userId);

            var user = await data.Users
                .Where(s => s.Id == userId)
                .Where(s => s.FirstName == "Test")
                .Where(s => s.LastName == "Test")
                .Where(s => s.UserRole == "User")
                .FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(user, Is.Not.Null);

            #endregion
        }

        [Test]
        public async Task GetUser_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);
            var userId = Guid.NewGuid();

            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "Test",
                LastName = "Test",
                UserRole = "User"
            });

            data.SaveChanges();

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
                           => await userService.GetUserAsync(Guid.NewGuid()));
            #endregion
        }

        [Test]
        public async Task ApproveStudio_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);
            var studioId = Guid.NewGuid();

            data.Studios.Add(new Studio()
            {
                Id = studioId,
                Location = "Testtest",
                Description = "Testtesttest",
                Name = "Testtest",
                IsApproved = false
            });

            data.SaveChanges();

            #endregion

            #region Act

            await userService.ApproveStudioAsync(studioId);

            var studio = await data.Studios
                .Where(s => s.IsApproved == true)
                .Where(s => s.Id == studioId)
                .Where(s => s.Location == "Testtest")
                .Where(s => s.Name == "Testtest")
                .Where(s => s.Description == "Testtesttest")
                .FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(studio, Is.Not.Null);

            #endregion
        }

        [Test]
        public async Task ApproveStudio_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);
            var studioId = Guid.NewGuid();

            data.Studios.Add(new Studio()
            {
                Id = studioId,
                Location = "Testtest",
                Description = "Testtesttest",
                Name = "Testtest",
                IsApproved = false
            });

            data.SaveChanges();

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
                           => await userService.ApproveStudioAsync(Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task EditUserProfile_ThrowsIfRequestIsNull()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await userService.EditUserProfileAsync(null, Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task EditUserProfile_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);

            var userId = Guid.NewGuid();

            data.Users.Add(new User
            {
                Id = userId,
                FirstName = "Test",
                LastName = "Test",
                UserRole = "User",
                Email = "test@mail.com",
                NormalizedEmail = "test@mail.com".ToUpper(),
                UserName = "test",
                NormalizedUserName = "test".ToUpper()
            });

            data.SaveChanges();

            var request = new EditProfileViewModel()
            {
                FirstName = "Testtest",
                LastName = "Testtest",
                Email = "testt@mail.com",
            };

            #endregion

            #region Act

            await userService.EditUserProfileAsync(request, userId);

            #endregion

            #region Assert

            Assert.That(request.FirstName, Is.EqualTo("Testtest"));
            Assert.That(request.LastName, Is.EqualTo("Testtest"));
            Assert.That(request.Email, Is.EqualTo("testt@mail.com"));

            #endregion
        }
    }
}
