using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Rating;

namespace TheBeautyForum.Services.Rating
{
    public class RatingService : IRatingService
    {
        private readonly ApplicationDbContext _dbContext;

        public RatingService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task UpdateStudioRatingAsync(RatingViewModel model, Guid userId)
        {
            var ratings = await _dbContext.Ratings
                .Where(x => x.UserId == userId && x.StudioId == model.Id)
                .ToListAsync();

            _dbContext.Ratings.RemoveRange(ratings);

            var rating = new Data.Models.Rating()
            {
                Id = Guid.NewGuid(),
                StudioId = model.Id,
                UserId = userId,
                Value = model.Value
            };

            await _dbContext.Ratings.AddAsync(rating);
            await _dbContext.SaveChangesAsync();
        }
    }
}
