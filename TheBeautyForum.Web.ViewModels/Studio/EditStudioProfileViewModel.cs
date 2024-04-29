using System.ComponentModel.DataAnnotations;
using TheBeautyForum.Web.ViewModels.Category;
using static TheBeautyForum.Data.DataConstants.Studio;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    /// <summary>
    /// Represents a edit studio view model.
    /// </summary>
    public class EditStudioProfileViewModel
    {
        /// <summary>
        /// Gets or sets the studio ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(NAME_MAX_LENGTH, MinimumLength = NAME_MIN_LENGTH)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the profile picture URL.
        /// </summary>
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// Gets or sets the open time.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public string OpenTime { get; set; } = null!;

        /// <summary>
        /// Gets or sets the close time.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public string CloseTime { get; set; } = null!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(DESCRIPTION_MAX_LENGTH, MinimumLength = DESCRIPTION_MIN_LENGTH)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        [RegularExpression(@"^(\w+(?:\s\w+)*), (\w+(?:\s\w+)*), ([\w\s]+(?:\d*)[\w\s]*)$", ErrorMessage = "Invalid location format.")]
        [StringLength(LOCATION_MAX_LENGTH, MinimumLength = LOCATION_MIN_LENGTH)]
        public string Location { get; set; } = null!;

        /// <summary>
        /// Gets or sets the chosen categories IDs.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public List<Guid> CategoryIds { get; set; }
            = new List<Guid>();

        /// <summary>
        /// Gets or sets all categories.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public List<CategoryViewModel> Categories { get; set; }
            = new List<CategoryViewModel>();
    }
}
