using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    /// <summary>
    /// Represents a filter for studios view model.
    /// </summary>
    public class FilterViewModel
    {
        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public string? Location { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        public string? Rating { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public List<CategoryViewModel> Categories { get; set; }
            = new List<CategoryViewModel>();

        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        public ICollection<string> Locations { get; set; }
            = new HashSet<string>();
    }
}
