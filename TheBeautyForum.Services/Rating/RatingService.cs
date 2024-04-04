using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Rating;

namespace TheBeautyForum.Services.Rating
{
    /// <summary>
    /// Represents rating service.
    /// </summary>
    public class RatingService : IRatingService
    {
        private readonly ApplicationDbContext _dbContext;

        /// <summary>
        /// Initialize a new instance of the <see cref="RatingService"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public RatingService(
            ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        /// <inheritdoc/>
        public async Task UpdateStudioRatingAsync(
            RatingViewModel model, 
            Guid userId)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            
            var ratings = await _dbContext.Ratings
                .Where(x => x.UserId == userId && x.StudioId == model.StudioId)
                .ToListAsync();

            _dbContext.Ratings.RemoveRange(ratings);

            var rating = new Data.Models.Rating()
            {
                Id = Guid.NewGuid(),
                StudioId = model.StudioId,
                UserId = userId,
                Value = model.Value
            };

            await _dbContext.Ratings.AddAsync(rating);
            await _dbContext.SaveChangesAsync();
        }
    }
}
