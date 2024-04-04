using TheBeautyForum.Web.ViewModels.Rating;

namespace TheBeautyForum.Services.Rating
{
    /// <summary>
    /// Provides access to ratings.
    /// </summary>
    public interface IRatingService
    {
        /// <summary>
        /// Updates studio rating.
        /// </summary>
        /// <param name="model">the model for updating the rating</param>
        /// <param name="userId">the ID of the user rating the studio</param>
        Task UpdateStudioRatingAsync(RatingViewModel model, Guid userId);
    }
}
