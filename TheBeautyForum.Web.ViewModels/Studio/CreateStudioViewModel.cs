using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Studio;
using TheBeautyForum.Web.ViewModels.Category;
using Microsoft.AspNetCore.Http;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    /// <summary>
    /// Represents an create studio view model.
    /// </summary>
    public class CreateStudioViewModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(NAME_MAX_LENGTH, MinimumLength = NAME_MIN_LENGTH)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the profile picture.
        /// </summary>
        public IFormFile? ProfilePicture { get; set; }

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
        [RegularExpression(@"^[^\s,""]+\s*,\s*[^\s,""]+\s*,\s*(?:(?![\d,""]).)+(?:\s+\d+)?$", ErrorMessage = "Invalid location format.")]
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
