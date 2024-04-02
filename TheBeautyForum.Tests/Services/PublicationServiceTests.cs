using CloudinaryDotNet;
using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Services.Images;
using TheBeautyForum.Services.Publication;
using TheBeautyForum.Tests.Mocks;
using TheBeautyForum.Web.ViewModels.Publication;

namespace TheBeautyForum.Tests.Services
{
    [TestFixture]
    public class PublicationServiceTests
    {
        [Test]
        public async Task CreatePublication_CorrectRequest()
        {
            #region Arrange

            var data = DatabaseMock.Instance;

            var studioId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            var request = new CreatePublicationViewModel()
            {
                StudioId = studioId,
                Description = "testtesttest",
            };

            var account = new Account(
                           "cloud_name",
                           "api_key",
                           "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var publicationService = new PublicationService(data, imageService);

            #endregion

            #region Act

            await publicationService.CreatePublicationAsync(request, userId);

            var post = await data.Publications
                .Where(c => c.UserId == userId && c.StudioId == request.StudioId)
                .FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(post, Is.Not.Null);

            #endregion
        }

        [Test]
        public async Task CreatePublication_ThrowIfModelIsNull()
        {
            #region Arrange

            var data = DatabaseMock.Instance;

            var account = new Account(
                           "cloud_name",
                           "api_key",
                           "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var publicationService = new PublicationService(data, imageService);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await publicationService.CreatePublicationAsync(null, Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task DeletePublication_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var publicationService = new PublicationService(data, imageService);

            var id = Guid.NewGuid();

            data.Publications.Add(new Publication()
            {
                Id = id,
                Description = "Testtesttest",
                StudioId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
            });

            data.SaveChanges();

            #endregion

            #region Act

            await publicationService.DeletePublicationAsync(id);

            var post = await data.Categories.FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(post, Is.Null);

            #endregion
        }

        [Test]
        public async Task DeletePublication_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var publicationService = new PublicationService(data, imageService);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
              => await publicationService.DeletePublicationAsync(Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task ShowForumAsync_ThrowsIfIdIsNonExistent()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var publicationService = new PublicationService(data, imageService);

            data.Publications.Add(new Publication
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                StudioId = Guid.NewGuid(),
                Description = "TestDescTestDescTestDescTestDescTestDesc",
                User = new User
                {
                    Id = Guid.NewGuid(),
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
               => await publicationService.ForumAsync(Guid.NewGuid()));

            #endregion
        }

        [Test]
        public async Task ShowForumAsync_ReturnsForum()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var account = new Account(
                                       "cloud_name",
                                       "api_key",
                                       "api_secret");
            var cloudinary = new Cloudinary(account);
            var imageService = new ImageService(data, cloudinary);
            var publicationService = new PublicationService(data, imageService);

            var userId = Guid.NewGuid();
            var studioId = Guid.NewGuid();
            var postId = Guid.NewGuid();

            data.Users.Add(new User
            {
                Id = userId,
                FirstName = "UserTestName",
                LastName = "UserTestName",
                UserRole = "User",
            });
            data.Studios.Add(new Studio()
            {
                Id = studioId,
                Name = "StudioName",
                StudioPictureUrl = "TestImage",
                Description = "Testtesttest",
                UserId = userId,
                IsApproved = true,
                Location = "Testtesttest",
                CloseTime = TimeOnly.MaxValue,
                OpenTime = TimeOnly.MinValue,
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
                Likes = new List<Like>()
            });

            data.SaveChanges();

            #endregion

            #region Act

            var result = await publicationService.ForumAsync(userId);

            #endregion

            #region Assert

            Assert.That(result, Is.Not.Null);

            #endregion
        }
    }
}
