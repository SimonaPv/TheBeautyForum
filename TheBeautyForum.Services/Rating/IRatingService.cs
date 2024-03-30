using TheBeautyForum.Web.ViewModels.Rating;

namespace TheBeautyForum.Services.Rating
{
    public interface IRatingService
    {
        Task UpdateStudioRatingAsync(RatingViewModel model, Guid userId);
    }
}
