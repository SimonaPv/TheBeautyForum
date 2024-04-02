using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Services.Category;
using TheBeautyForum.Services.Images;
using TheBeautyForum.Services.Rating;
using TheBeautyForum.Services.Studios;
using TheBeautyForum.Tests.Mocks;
using TheBeautyForum.Web.ViewModels.Rating;

namespace TheBeautyForum.Tests.Services
{
    [TestFixture]
    public class RatingServiceTests
    {
        [Test]
        public async Task UpdateRating_CorrectRequest()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var ratingService = new RatingService(data);

            var userId = Guid.NewGuid();

            var request = new RatingViewModel()
            {
                Value = 5,
                StudioId = Guid.NewGuid(),
                UserId = userId
            };

            #endregion

            #region Act

            await ratingService.UpdateStudioRatingAsync(request, userId);

            var rating = await data.Ratings
                .FirstOrDefaultAsync();

            #endregion

            #region Assert

            Assert.That(rating, Is.Not.Null);

            #endregion
        }

        [Test]
        public async Task UpdateRating_ThrowsIfRequestIsNull()
        {
            #region Arrange

            using var data = DatabaseMock.Instance;

            var studioService = new RatingService(data);

            #endregion

            #region Act

            #endregion

            #region Assert

            ArgumentNullException ex = Assert.ThrowsAsync<ArgumentNullException>(async ()
               => await studioService.UpdateStudioRatingAsync(null, Guid.NewGuid()));

            #endregion
        }
    }
}
