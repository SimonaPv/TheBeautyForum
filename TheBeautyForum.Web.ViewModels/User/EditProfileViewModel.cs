using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.User;

namespace TheBeautyForum.Web.ViewModels.User
{
    /// <summary>
    /// Represents a edit profile user view model.
    /// </summary>
    public class EditProfileViewModel
    {
        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(FIRST_NAME_MAX_LENGTH, MinimumLength = FIRST_NAME_MIN_LENGTH)]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(LAST_NAME_MAX_LENGTH, MinimumLength = LAST_NAME_MIN_LENGTH)]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the profile picture URL.
        /// </summary>
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        [EmailAddress]
        public string Email { get; set; } = null!;
    }
}
