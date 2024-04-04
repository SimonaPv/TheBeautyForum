using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    /// <summary>
    /// Represents a studio view model.
    /// </summary>
    public class ViewStudioViewModel
    {
        /// <summary>
        /// Gets or sets the studio ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the profile picture URL.
        /// </summary>
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// Gets or sets the open time.
        /// </summary>
        public string OpenTime { get; set; } = null!;

        /// <summary>
        /// Gets or sets the close time.
        /// </summary>
        public string CloseTime { get; set; } = null!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public string Location { get; set; } = null!;

        /// <summary>
        /// Gets or sets the average rating.
        /// </summary>
        public double? RatingSum { get; set; }

        /// <summary>
        /// Gets or sets the filter for all studios.
        /// </summary>
        public FilterViewModel? Filter { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public List<CategoryViewModel> Categories { get; set; }
            = new List<CategoryViewModel>();
    }
}
