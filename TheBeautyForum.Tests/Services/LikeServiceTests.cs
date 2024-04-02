using TheBeautyForum.Data.Models;
using TheBeautyForum.Services.Like;
using TheBeautyForum.Tests.Mocks;

namespace TheBeautyForum.Tests.Services
{
    [TestFixture]
    public class LikeServiceTests
    {
        [Test]
        public async Task LikePost_CorrectRequest()
        {
            #region Arrange

            var data = DatabaseMock.Instance;

            var postId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "test",
                LastName = "test",
                UserRole = "User"
            });

            data.Likes.Add(new Like()
            {
                Id = Guid.NewGuid(),
                PublicationId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
            });

            data.Likes.Add(new Like()
            {
                Id = Guid.NewGuid(),
                PublicationId = postId,
                UserId = Guid.NewGuid(),
            });

            data.Likes.Add(new Like()
            {
                Id = Guid.NewGuid(),
                PublicationId = postId,
                UserId = Guid.NewGuid(),
            });

            data.SaveChanges();

            var likeService = new LikeService(data);

            #endregion

            #region Act

            await likeService.HandleLikePostAsync(postId, userId);

            #endregion

            #region Assert

            Assert.That(data.Likes.Count(), Is.EqualTo(4));

            #endregion
        }

        [Test]
        public async Task DislikePost_CorrectRequest()
        {
            #region Arrange

            var data = DatabaseMock.Instance;

            var postId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "test",
                LastName = "test",
                UserRole = "User"
            });

            data.Likes.Add(new Like()
            {
                Id = Guid.NewGuid(),
                PublicationId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
            });

            data.Likes.Add(new Like()
            {
                Id = Guid.NewGuid(),
                PublicationId = postId,
                UserId = userId,
            });

            data.Likes.Add(new Like()
            {
                Id = Guid.NewGuid(),
                PublicationId = postId,
                UserId = Guid.NewGuid(),
            });

            data.SaveChanges();

            var likeService = new LikeService(data);

            #endregion

            #region Act

            await likeService.HandleLikePostAsync(postId, userId);

            #endregion

            #region Assert

            Assert.That(data.Likes.Count(), Is.EqualTo(2));

            #endregion
        }

        [Test]
        public async Task DislikePost_ThrowIfLikeIdIsNonExistent()
        {
            #region Arrange

            var data = DatabaseMock.Instance;

            var postId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            data.Users.Add(new User()
            {
                Id = userId,
                FirstName = "test",
                LastName = "test",
                UserRole = "User"
            });

            data.Likes.Add(new Like()
            {
                Id = Guid.NewGuid(),
                PublicationId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
            });

            data.Likes.Add(new Like()
            {
                Id = Guid.NewGuid(),
                PublicationId = postId,
                UserId = userId,
            });

            data.Likes.Add(new Like()
            {
                Id = Guid.NewGuid(),
                PublicationId = postId,
                UserId = Guid.NewGuid(),
            });

            data.SaveChanges();

            var likeService = new LikeService(data);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await likeService.HandleLikePostAsync(Guid.NewGuid(), Guid.NewGuid()));

            #endregion
        }
    }
}
