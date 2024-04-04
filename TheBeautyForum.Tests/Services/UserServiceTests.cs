using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Services.Users;
using TheBeautyForum.Tests.Mocks;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Publication;
using TheBeautyForum.Web.ViewModels.Rating;
using TheBeautyForum.Web.ViewModels.Studio;
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

        [Test]
        public async Task ShowStudioCreatorProfileAsync_ReturnsUserProfile()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);

            var studioId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            data.Studios.Add(new Studio
            {
                Id = studioId,
                UserId = userId,
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
            });
            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "test",
                LastName = "test",
                UserRole = "User",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
            });

            data.SaveChanges();

            var model = new ProfileViewModel()
            {
                UserId = userId,
                FirstName = "test",
                LastName = "test",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
                FavoriteStudios = new List<StudioUserViewModel>()
            };
            model.FavoriteStudios.Add(new StudioUserViewModel()
            {
                StudioId = studioId,
                StudioName = "StudioTest",
                StudioDescription = "TestDescTestDescTestDescTestDescTestDesc",
                ProfilePicUrl = "TestImage",
                IsApproved = false,
            });

            #endregion

            #region Act

            var result = await userService.ShowStudioCreatorLoggedProfileAsync(userId);

            #endregion

            #region Assert

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Email, Is.EqualTo(model.Email));
            Assert.That(result.UserId, Is.EqualTo(model.UserId));
            Assert.That(result.FirstName, Is.EqualTo(model.FirstName));
            Assert.That(result.LastName, Is.EqualTo(model.LastName));
            Assert.That(result.ProfilePictureUrl, Is.EqualTo(model.ProfilePictureUrl));
            Assert.That(result.FavoriteStudios.Count(), Is.EqualTo(model.FavoriteStudios.Count()));

            #endregion
        }

        [Test]
        public async Task ShowStudioCreatorProfileAsync_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);

            var studioId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            data.Studios.Add(new Studio
            {
                Id = studioId,
                UserId = userId,
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
            });
            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "test",
                LastName = "test",
                UserRole = "User",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
            });

            data.SaveChanges();

            var model = new ProfileViewModel()
            {
                UserId = userId,
                FirstName = "test",
                LastName = "test",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
                FavoriteStudios = new List<StudioUserViewModel>()
            };
            model.FavoriteStudios.Add(new StudioUserViewModel()
            {
                StudioId = studioId,
                StudioName = "StudioTest",
                StudioDescription = "TestDescTestDescTestDescTestDescTestDesc",
                ProfilePicUrl = "TestImage",
                IsApproved = false,
            });

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await userService.ShowStudioCreatorLoggedProfileAsync(Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task ShowUserProfileAsync_ReturnsUserProfile()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);

            var studioId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var loggedUserId = Guid.NewGuid();
            var postId = Guid.NewGuid();
            var appointmentId = Guid.NewGuid();
            var categoryId = Guid.NewGuid();

            data.Studios.Add(new Studio
            {
                Id = studioId,
                UserId = Guid.NewGuid(),
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
                Ratings = new List<Rating>()
            });
            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "test",
                LastName = "test",
                UserRole = "User",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
                Appointments = new List<Appointment>()
            });
            data.Ratings.Add(new Rating()
            {
                Id = Guid.NewGuid(),
                StudioId = studioId,
                UserId = userId,
                Value = 4
            });
            data.Images.Add(new Image()
            {
                Id = Guid.NewGuid(),
                UrlPath = "test",
                PublicationId = postId
            });
            data.Publications.Add(new Publication()
            {
                Id = postId,
                UserId = userId,
                Description = "test",
                StudioId = studioId,
                DatePosted = DateTime.Now,
            });
            data.Appointments.Add(new Appointment()
            {
                Id = appointmentId,
                Description = "test",
                CategoryId = categoryId,
                UserId = userId,
                StudioId = studioId,
                StartDate = DateTime.Now,
            });
            data.Categories.Add(new Category()
            {
                Id = categoryId,
                Name = "test"
            });

            data.SaveChanges();

            var model = new ProfileViewModel()
            {
                UserId = userId,
                FirstName = "test",
                LastName = "test",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
                FavoriteStudios = new List<StudioUserViewModel>(),
                Ratings = new List<RatingViewModel>(),
                Images = new List<string>() { "test" },
                Publications = new List<PostForumViewModel>(),
                Appointments = new List<AppointmentViewModel>()
            };
            model.Appointments.Add(new AppointmentViewModel()
            {
                Id = appointmentId,
                Description = "test",
                CategoryName = "name",
                UserId = userId,
                StartDate = DateTime.Now,
            });
            model.Publications.Add(new PostForumViewModel()
            {
                Id = postId,
                UserId = userId,
                Description = "test",
                StudioId = studioId,
                DatePosted = DateTime.Now,
            });
            model.FavoriteStudios.Add(new StudioUserViewModel()
            {
                StudioId = studioId,
                StudioName = "StudioTest",
                StudioDescription = "TestDescTestDescTestDescTestDescTestDesc",
                ProfilePicUrl = "TestImage",
                IsApproved = true,
                RatingSum = 4
            });
            model.Ratings.Add(new RatingViewModel()
            {
                Id = Guid.NewGuid(),
                Value = 4,
                StudioId = studioId,
                UserId = userId,
            });

            #endregion

            #region Act

            var result = await userService.ShowUserProfileAsync(userId, loggedUserId);

            #endregion

            #region Assert

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Email, Is.EqualTo(model.Email));
            Assert.That(result.UserId, Is.EqualTo(model.UserId));
            Assert.That(result.FirstName, Is.EqualTo(model.FirstName));
            Assert.That(result.LastName, Is.EqualTo(model.LastName));
            Assert.That(result.ProfilePictureUrl, Is.EqualTo(model.ProfilePictureUrl));
            Assert.That(result.FavoriteStudios.Count(), Is.EqualTo(model.FavoriteStudios.Count()));
            Assert.That(result.Appointments.Count(), Is.EqualTo(model.Appointments.Count()));
            Assert.That(result.Images.Count(), Is.EqualTo(model.Images.Count()));
            Assert.That(result.Ratings.Count(), Is.EqualTo(model.Ratings.Count()));
            Assert.That(result.Publications.Count(), Is.EqualTo(model.Publications.Count()));

            #endregion
        }

        [Test]
        public async Task ShowUserProfileAsync_ThrowsIfIdIsNonExisent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);

            var studioId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var loggedUserId = Guid.NewGuid();
            var postId = Guid.NewGuid();
            var appointmentId = Guid.NewGuid();
            var categoryId = Guid.NewGuid();

            data.Studios.Add(new Studio
            {
                Id = studioId,
                UserId = Guid.NewGuid(),
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
                Ratings = new List<Rating>()
            });
            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "test",
                LastName = "test",
                UserRole = "User",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
                Appointments = new List<Appointment>()
            });
            data.Ratings.Add(new Rating()
            {
                Id = Guid.NewGuid(),
                StudioId = studioId,
                UserId = userId,
                Value = 4
            });
            data.Images.Add(new Image()
            {
                Id = Guid.NewGuid(),
                UrlPath = "test",
                PublicationId = postId
            });
            data.Publications.Add(new Publication()
            {
                Id = postId,
                UserId = userId,
                Description = "test",
                StudioId = studioId,
                DatePosted = DateTime.Now,
            });
            data.Appointments.Add(new Appointment()
            {
                Id = appointmentId,
                Description = "test",
                CategoryId = categoryId,
                UserId = userId,
                StudioId = studioId,
                StartDate = DateTime.Now,
            });
            data.Categories.Add(new Category()
            {
                Id = categoryId,
                Name = "test"
            });

            data.SaveChanges();

            var model = new ProfileViewModel()
            {
                UserId = userId,
                FirstName = "test",
                LastName = "test",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
                FavoriteStudios = new List<StudioUserViewModel>(),
                Ratings = new List<RatingViewModel>(),
                Images = new List<string>() { "test" },
                Publications = new List<PostForumViewModel>(),
                Appointments = new List<AppointmentViewModel>()
            };
            model.Appointments.Add(new AppointmentViewModel()
            {
                Id = appointmentId,
                Description = "test",
                CategoryName = "name",
                UserId = userId,
                StartDate = DateTime.Now,
            });
            model.Publications.Add(new PostForumViewModel()
            {
                Id = postId,
                UserId = userId,
                Description = "test",
                StudioId = studioId,
                DatePosted = DateTime.Now,
            });
            model.FavoriteStudios.Add(new StudioUserViewModel()
            {
                StudioId = studioId,
                StudioName = "StudioTest",
                StudioDescription = "TestDescTestDescTestDescTestDescTestDesc",
                ProfilePicUrl = "TestImage",
                IsApproved = true,
                RatingSum = 4
            });
            model.Ratings.Add(new RatingViewModel()
            {
                Id = Guid.NewGuid(),
                Value = 4,
                StudioId = studioId,
                UserId = userId,
            });

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await userService.ShowUserProfileAsync(Guid.NewGuid(), loggedUserId));

            #endregion
        }

        [Test]
        public async Task ShowLoggedUserProfileAsync_ReturnsUserProfile()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);

            var studioId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var loggedUserId = Guid.NewGuid();
            var postId = Guid.NewGuid();
            var appointmentId = Guid.NewGuid();
            var categoryId = Guid.NewGuid();

            data.Studios.Add(new Studio
            {
                Id = studioId,
                UserId = Guid.NewGuid(),
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
                Ratings = new List<Rating>()
            });
            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "test",
                LastName = "test",
                UserRole = "User",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
                Appointments = new List<Appointment>()
            });
            data.Ratings.Add(new Rating()
            {
                Id = Guid.NewGuid(),
                StudioId = studioId,
                UserId = userId,
                Value = 4
            });
            data.Images.Add(new Image()
            {
                Id = Guid.NewGuid(),
                UrlPath = "test",
                PublicationId = postId
            });
            data.Publications.Add(new Publication()
            {
                Id = postId,
                UserId = userId,
                Description = "test",
                StudioId = studioId,
                DatePosted = DateTime.Now,
            });
            data.Appointments.Add(new Appointment()
            {
                Id = appointmentId,
                Description = "test",
                CategoryId = categoryId,
                UserId = userId,
                StudioId = studioId,
                StartDate = DateTime.Now,
            });
            data.Categories.Add(new Category()
            {
                Id = categoryId,
                Name = "test"
            });

            data.SaveChanges();

            var model = new ProfileViewModel()
            {
                UserId = userId,
                FirstName = "test",
                LastName = "test",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
                FavoriteStudios = new List<StudioUserViewModel>(),
                Ratings = new List<RatingViewModel>(),
                Images = new List<string>() { "test" },
                Publications = new List<PostForumViewModel>(),
                Appointments = new List<AppointmentViewModel>()
            };
            model.Appointments.Add(new AppointmentViewModel()
            {
                Id = appointmentId,
                Description = "test",
                CategoryName = "name",
                UserId = userId,
                StartDate = DateTime.Now,
            });
            model.Publications.Add(new PostForumViewModel()
            {
                Id = postId,
                UserId = userId,
                Description = "test",
                StudioId = studioId,
                DatePosted = DateTime.Now,
            });
            model.FavoriteStudios.Add(new StudioUserViewModel()
            {
                StudioId = studioId,
                StudioName = "StudioTest",
                StudioDescription = "TestDescTestDescTestDescTestDescTestDesc",
                ProfilePicUrl = "TestImage",
                IsApproved = true,
                RatingSum = 4
            });
            model.Ratings.Add(new RatingViewModel()
            {
                Id = Guid.NewGuid(),
                Value = 4,
                StudioId = studioId,
                UserId = userId,
            });

            #endregion

            #region Act

            var result = await userService.ShowLoggedProfileAsync(userId);

            #endregion

            #region Assert

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Email, Is.EqualTo(model.Email));
            Assert.That(result.UserId, Is.EqualTo(model.UserId));
            Assert.That(result.FirstName, Is.EqualTo(model.FirstName));
            Assert.That(result.LastName, Is.EqualTo(model.LastName));
            Assert.That(result.ProfilePictureUrl, Is.EqualTo(model.ProfilePictureUrl));
            Assert.That(result.Appointments.Count(), Is.EqualTo(model.Appointments.Count()));
            Assert.That(result.Images.Count(), Is.EqualTo(model.Images.Count()));
            Assert.That(result.Ratings.Count(), Is.EqualTo(model.Ratings.Count()));
            Assert.That(result.Publications.Count(), Is.EqualTo(model.Publications.Count()));

            #endregion
        }

        [Test]
        public async Task ShowLoggedUserProfileAsync_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userService = new UserService(data);

            var studioId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var loggedUserId = Guid.NewGuid();
            var postId = Guid.NewGuid();
            var appointmentId = Guid.NewGuid();
            var categoryId = Guid.NewGuid();

            data.Studios.Add(new Studio
            {
                Id = studioId,
                UserId = Guid.NewGuid(),
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
                Ratings = new List<Rating>()
            });
            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "test",
                LastName = "test",
                UserRole = "User",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
                Appointments = new List<Appointment>()
            });
            data.Ratings.Add(new Rating()
            {
                Id = Guid.NewGuid(),
                StudioId = studioId,
                UserId = userId,
                Value = 4
            });
            data.Images.Add(new Image()
            {
                Id = Guid.NewGuid(),
                UrlPath = "test",
                PublicationId = postId
            });
            data.Publications.Add(new Publication()
            {
                Id = postId,
                UserId = userId,
                Description = "test",
                StudioId = studioId,
                DatePosted = DateTime.Now,
            });
            data.Appointments.Add(new Appointment()
            {
                Id = appointmentId,
                Description = "test",
                CategoryId = categoryId,
                UserId = userId,
                StudioId = studioId,
                StartDate = DateTime.Now,
            });
            data.Categories.Add(new Category()
            {
                Id = categoryId,
                Name = "test"
            });

            data.SaveChanges();

            var model = new ProfileViewModel()
            {
                UserId = userId,
                FirstName = "test",
                LastName = "test",
                ProfilePictureUrl = "test",
                Email = "test@mail.com",
                FavoriteStudios = new List<StudioUserViewModel>(),
                Ratings = new List<RatingViewModel>(),
                Images = new List<string>() { "test" },
                Publications = new List<PostForumViewModel>(),
                Appointments = new List<AppointmentViewModel>()
            };
            model.Appointments.Add(new AppointmentViewModel()
            {
                Id = appointmentId,
                Description = "test",
                CategoryName = "name",
                UserId = userId,
                StartDate = DateTime.Now,
            });
            model.Publications.Add(new PostForumViewModel()
            {
                Id = postId,
                UserId = userId,
                Description = "test",
                StudioId = studioId,
                DatePosted = DateTime.Now,
            });
            model.FavoriteStudios.Add(new StudioUserViewModel()
            {
                StudioId = studioId,
                StudioName = "StudioTest",
                StudioDescription = "TestDescTestDescTestDescTestDescTestDesc",
                ProfilePicUrl = "TestImage",
                IsApproved = true,
                RatingSum = 4
            });
            model.Ratings.Add(new RatingViewModel()
            {
                Id = Guid.NewGuid(),
                Value = 4,
                StudioId = studioId,
                UserId = userId,
            });

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await userService.ShowLoggedProfileAsync(Guid.NewGuid()));

            #endregion
        }
    }
}