using CloudinaryDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Services.Category;
using TheBeautyForum.Services.Images;
using TheBeautyForum.Services.Studios;
using TheBeautyForum.Tests.Mocks;
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
    }
}
