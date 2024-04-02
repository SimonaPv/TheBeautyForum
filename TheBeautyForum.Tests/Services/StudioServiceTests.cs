using CloudinaryDotNet;
using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Services.Category;
using TheBeautyForum.Services.Images;
using TheBeautyForum.Services.Studios;
using TheBeautyForum.Tests.Mocks;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Category;
using TheBeautyForum.Web.ViewModels.Publication;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Tests.Services
{
    [TestFixture]
    public class StudioServiceTests
    {
        [Test]
        public async Task ListStudios_ReturnAllStudiosNoFilter()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;
            var studioId1 = Guid.NewGuid();
            var studioId2 = Guid.NewGuid();

            data.Studios.Add(new Studio
            {
                Id = studioId1,
                UserId = Guid.NewGuid(),
                Name = "StudioTest",
                Location = "text, text, text",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
                User = new User
                {
                    FirstName = "UserTestName",
                    LastName = "UserTestName",
                    UserRole = "test"
                },
                IsApproved = true,
            });
            data.Studios.Add(new Studio
            {
                Id = studioId2,
                UserId = Guid.NewGuid(),
                Name = "StudioTest2",
                Location = "text, text, text",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDesc2TestDesc2TestDesc2TestDesc2TestDesc2",
                StudioPictureUrl = "TestImage2",
                User = new User
                {
                    FirstName = "UserTestName2",
                    LastName = "UserTestName2",
                    UserRole = "test"
                },
                IsApproved = true,
            });
            data.StudiosCategories.Add(new StudioCategory()
            {
                CategoryId = Guid.NewGuid(),
                StudioId = studioId1,
                Category = new Category()
                {
                    Name = "text"
                }
            });
            data.StudiosCategories.Add(new StudioCategory()
            {
                CategoryId = Guid.NewGuid(),
                StudioId = studioId2,
                Category = new Category()
                {
                    Name = "text"
                }
            });

            data.SaveChanges();

            var account = new Account(
                "cloud_name",
                "api_key",
                "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);

            #endregion

            #region Act

            var result = await studioService.GetAllStudiosAsync(new FilterViewModel());

            #endregion

            #region Assert

            Assert.That(result.Count, Is.EqualTo(data.Studios.Count()));
            Assert.That(result, Is.TypeOf<List<ViewStudioViewModel>>());

            #endregion
        }

        [Test]
        public async Task ListStudios_ReturnAllStudiosWithFilter()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;
            var studioId1 = Guid.NewGuid();
            var studioId2 = Guid.NewGuid();

            data.Studios.Add(new Studio
            {
                Id = studioId1,
                UserId = Guid.NewGuid(),
                Name = "StudioTest",
                Location = "text, text, text",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
                User = new User
                {
                    FirstName = "UserTestName",
                    LastName = "UserTestName",
                    UserRole = "test"
                },
                IsApproved = true,
            });
            data.Studios.Add(new Studio
            {
                Id = studioId2,
                UserId = Guid.NewGuid(),
                Name = "StudioTest2",
                Location = "test, test, test",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDesc2TestDesc2TestDesc2TestDesc2TestDesc2",
                StudioPictureUrl = "TestImage2",
                User = new User
                {
                    FirstName = "UserTestName2",
                    LastName = "UserTestName2",
                    UserRole = "test"
                },
                IsApproved = true,
            });
            data.StudiosCategories.Add(new StudioCategory()
            {
                CategoryId = Guid.NewGuid(),
                StudioId = studioId1,
                Category = new Category()
                {
                    Name = "text"
                }
            });
            data.StudiosCategories.Add(new StudioCategory()
            {
                CategoryId = Guid.NewGuid(),
                StudioId = studioId2,
                Category = new Category()
                {
                    Name = "text"
                }
            });

            data.SaveChanges();

            var account = new Account(
                "cloud_name",
                "api_key",
                "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);

            #endregion

            #region Act

            var result = await studioService.GetAllStudiosAsync(new FilterViewModel()
            {
                Location = "text, text",
                Rating = "none",
                Category = "none"
            });

            #endregion

            #region Assert

            Assert.That(result.Count, Is.EqualTo(data.Studios.Where(x => x.Location == "text, text, text").Count()));
            Assert.That(result, Is.TypeOf<List<ViewStudioViewModel>>());

            #endregion
        }

        [Test]
        public async Task GetStudio_ReturnStudio()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var studioId = Guid.NewGuid();

            var studio = new Studio
            {
                Id = studioId,
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
                User = new User
                {
                    FirstName = "UserTestName",
                    LastName = "UserTestName",
                    UserRole = "User"
                }
            };
            data.Studios.Add(studio);

            data.Studios.Add(new Studio
            {
                Name = "StudioTest2",
                Location = "TestLocation2",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDesc2TestDesc2TestDesc2TestDesc2TestDesc2",
                StudioPictureUrl = "TestImage2",
                User = new User
                {
                    FirstName = "UserTestName2",
                    LastName = "UserTestName2",
                    UserRole = "User"
                }
            });

            data.SaveChanges();

            var account = new Account(
                            "cloud_name",
                            "api_key",
                            "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);

            #endregion

            #region Act

            var result = await studioService.GetStudioAsync(studioId);

            #endregion

            #region Assert

            Assert.That(result.Id, Is.EqualTo(studio.Id));
            Assert.That(result.Name, Is.EqualTo(studio.Name));
            Assert.That(result.Location, Is.EqualTo(studio.Location));
            Assert.That(result.Description, Is.EqualTo(studio.Description));
            Assert.That(result.ProfilePictureUrl, Is.EqualTo(studio.StudioPictureUrl));
            Assert.That(result.OpenTime, Is.EqualTo(studio.OpenTime.ToString()));
            Assert.That(result.CloseTime, Is.EqualTo(studio.CloseTime.ToString()));

            Assert.That(result, Is.TypeOf<EditStudioProfileViewModel>());

            #endregion
        }

        [Test]
        public async Task GetStudio_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var studioId = Guid.NewGuid();

            data.Studios.Add(new Studio
            {
                UserId = Guid.NewGuid(),
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
                User = new User
                {
                    FirstName = "UserTestName",
                    LastName = "UserTestName",
                    UserRole = "text"
                }
            });
            data.Studios.Add(new Studio
            {
                UserId = Guid.NewGuid(),
                Name = "StudioTest2",
                Location = "TestLocation2",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDesc2TestDesc2TestDesc2TestDesc2TestDesc2",
                StudioPictureUrl = "TestImage2",
                User = new User
                {
                    FirstName = "UserTestName2",
                    LastName = "UserTestName2",
                    UserRole = "User"
                }
            });

            data.SaveChanges();

            var account = new Account(
                            "cloud_name",
                            "api_key",
                            "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
                           => await studioService.GetStudioAsync(Guid.NewGuid()));
            #endregion
        }

        [Test]
        public async Task DeleteStudio_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                            "cloud_name",
                            "api_key",
                            "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);

            var id = Guid.NewGuid();

            data.Studios.Add(new Studio()
            {
                Id = id,
                UserId = Guid.NewGuid(),
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage"
            });

            data.SaveChanges();

            #endregion

            #region Act

            await studioService.DeleteStudioAsync(id);

            var studios = await data.Studios.FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(studios, Is.Null);

            #endregion
        }

        [Test]
        public async Task DeleteStudio_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);
            var id = Guid.NewGuid();

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
              => await studioService.DeleteStudioAsync(id));

            #endregion
        }

        [Test]
        public async Task CreateStudio_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var userId = Guid.NewGuid();

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);

            var request = new CreateStudioViewModel()
            {
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue.ToString(),
                CloseTime = TimeOnly.MaxValue.ToString(),
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                CategoryIds = new List<Guid> { Guid.NewGuid() }
            };

            #endregion

            #region Act

            await studioService.CreateStudioAsync(request, userId);

            var studio = await data.Studios
                .Where(s => s.Name == request.Name)
                .Where(s => s.Location == request.Location)
                .Where(s => s.OpenTime.ToString() == request.OpenTime)
                .Where(s => s.CloseTime.ToString() == request.CloseTime)
                .Where(s => s.Description == request.Description)
                .Where(s => s.UserId == userId)
                .Where(s => s.StudioCategories.Count() == request.CategoryIds.Count())
                .FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(studio, Is.Not.Null);

            #endregion
        }

        [Test]
        public async Task CreateStudio_ThrowsIfRequestIsNull()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);
            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await studioService.CreateStudioAsync(null, Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task CreateStudioCategoriesAsync_ReturnsStudio()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            data.StudiosCategories.Add(new StudioCategory()
            {
                StudioId = Guid.NewGuid(),
                CategoryId = Guid.NewGuid(),
                Category = new Category()
                {
                    Name = "test"
                }
            });
            data.StudiosCategories.Add(new StudioCategory()
            {
                StudioId = Guid.NewGuid(),
                CategoryId = Guid.NewGuid(),
                Category = new Category()
                {
                    Name = "test"
                }
            });

            data.SaveChanges();

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);
            #endregion

            #region Act

            var result = await studioService.CreateStudioCategoriesAsync();

            #endregion

            #region Assert

            Assert.That(result.Categories.Count, Is.EqualTo(data.Categories.Count()));
            Assert.That(result, Is.TypeOf<CreateStudioViewModel>());

            #endregion
        }

        [Test]
        public async Task UpdateStudio_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                           "cloud_name",
                           "api_key",
                           "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);

            var studioId = Guid.NewGuid();

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
                User = new User
                {
                    FirstName = "UserTestName",
                    LastName = "UserTestName",
                    UserRole = "User"
                }
            });

            data.SaveChanges();

            var request = new EditStudioProfileViewModel()
            {
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue.ToString(),
                CloseTime = TimeOnly.MaxValue.ToString(),
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                ProfilePictureUrl = "TestImage",
                Categories = new List<CategoryViewModel>()
                {
                    new CategoryViewModel()
                    {
                        Id = Guid.NewGuid(),
                        Name = "TestName",
                    }
                }
            };

            #endregion

            #region Act

            await studioService.EditStudioProfileAsync(request, studioId);

            var studio = await data.Studios
               .Where(s => s.Name == request.Name)
               .Where(s => s.Location == request.Location)
               .Where(s => s.OpenTime.ToString() == request.OpenTime)
               .Where(s => s.CloseTime.ToString() == request.CloseTime)
               .Where(s => s.Description == request.Description)
               .Where(s => s.StudioPictureUrl == request.ProfilePictureUrl)
               .Where(s => s.StudioCategories.Count() == request.CategoryIds.Count())
               .FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(studio, Is.Not.Null);

            #endregion
        }

        [Test]
        public async Task UpdateStudio_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);

            data.Studios.Add(new Studio
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
                User = new User
                {
                    FirstName = "UserTestName",
                    LastName = "UserTestName",
                    UserRole = "User"
                }
            });

            data.SaveChanges();

            var request = new EditStudioProfileViewModel()
            {
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue.ToString(),
                CloseTime = TimeOnly.MaxValue.ToString(),
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                ProfilePictureUrl = "TestImage",
                Categories = new List<CategoryViewModel>()
                {
                    new CategoryViewModel()
                    {
                        Id = Guid.NewGuid(),
                        Name = "TestName",
                    }
                }
            };

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await studioService.EditStudioProfileAsync(request, Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task UpdateStudio_ThrowsIfRequestIsNull()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await studioService.EditStudioProfileAsync(null, Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task ShowStudioProfileAsync_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);

            data.Studios.Add(new Studio
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
                User = new User
                {
                    FirstName = "UserTestName",
                    LastName = "UserTestName",
                    UserRole = "User"
                }
            });

            data.SaveChanges();

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await studioService.ShowStudioProfileAsync(Guid.NewGuid(), Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task ShowStudioProfileAsync_ReturnsStudioProfile()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var categoryService = new CategoryService(data);
            var studioService = new StudioService(data, imageService, categoryService);

            var studioId = Guid.NewGuid();
            var postId = Guid.NewGuid();
            var userStudioId = Guid.NewGuid();
            var userPostId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var categoryId = Guid.NewGuid();
            var appointmentId = Guid.NewGuid();

            data.Studios.Add(new Studio
            {
                Id = studioId,
                UserId = userStudioId,
                Name = "StudioTest",
                Location = "TestLocation",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                StudioPictureUrl = "TestImage",
                User = new User
                {
                    Id = userStudioId,
                    FirstName = "UserTestName",
                    LastName = "UserTestName",
                    UserRole = "User"
                }
            });
            data.Publications.Add(new Publication()
            {
                Id = postId,
                UserId = userId,
                StudioId = studioId,
                Description = "testtesttesttest",
                Image = new Image()
                {
                    Id = Guid.NewGuid(),
                    PublicationId = postId,
                    UrlPath = "testtest"
                },
                DatePosted = DateTime.Now,
            });
            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "test",
                LastName = "test",
                UserRole = "User",
                ProfilePictureUrl = "test",
            });
            data.Categories.Add(new Category()
            {
                Id = categoryId,
                Name = "Test"
            });
            data.StudiosCategories.Add(new StudioCategory()
            {
                StudioId = studioId,
                CategoryId = categoryId
            });
            data.Appointments.Add(new Appointment()
            {
                Id = appointmentId,
                Description = "Testtesttesttest",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                CategoryId = categoryId,
                StudioId = studioId,
                UserId = userId
            });
            data.SaveChanges();

            var model = new StudioProfileViewModel()
            {
                StudioId = studioId,
                UserId = userStudioId,
                Name = "StudioTest",
                ProfilePictureUrl = "TestImage",
                RatingSum = 0,
                Location = "TestLocation",
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                OpenTime = TimeOnly.MinValue,
                CloseTime = TimeOnly.MaxValue,
                Publications = new List<PostForumViewModel>(),
                CategoryNames = new List<string>() { "Test" },
                Images = new List<string>() { "testtest" },
                Appointments = new List<AppointmentViewModel>()
            };

            model.Publications.Add(new PostForumViewModel()
            {
                Id = postId,
                UserId = userPostId,
                StudioId = studioId,
                Description = "testtesttesttest",
                ImageUrl = "testtest",
                DatePosted = DateTime.Now,
            });

            model.Appointments.Add(new AppointmentViewModel()
            {
                Id = appointmentId,
                UserId = userId,
                UserName = "test",
                StudioId = studioId,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Description = "Testtesttesttest",
                CategoryName = "Test",
                StudioName = "StudioTest"
            });

            #endregion

            #region Act

            var result = await studioService.ShowStudioProfileAsync(studioId, userId);

            #endregion

            #region Assert

            Assert.That(result, Is.Not.Null);
            Assert.That(result.StudioId, Is.EqualTo(model.StudioId));
            Assert.That(result.UserId, Is.EqualTo(userStudioId));
            Assert.That(result.Name, Is.EqualTo(model.Name));
            Assert.That(result.Location, Is.EqualTo(model.Location));
            Assert.That(result.Description, Is.EqualTo(model.Description));
            Assert.That(result.ProfilePictureUrl, Is.EqualTo(model.ProfilePictureUrl));
            Assert.That(result.OpenTime, Is.EqualTo(model.OpenTime));
            Assert.That(result.CloseTime, Is.EqualTo(model.CloseTime));
            Assert.That(result.RatingSum, Is.EqualTo(model.RatingSum));
            Assert.That(result.Appointments.Count(), Is.EqualTo(model.Appointments.Count()));
            Assert.That(result.Publications.Count(), Is.EqualTo(model.Publications.Count()));
            Assert.That(result.Images.Count(), Is.EqualTo(model.Images.Count()));
            Assert.That(result.CategoryNames.Count(), Is.EqualTo(model.CategoryNames.Count()));

            #endregion
        }
    }
}
