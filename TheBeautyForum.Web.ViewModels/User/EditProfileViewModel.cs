using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.User;

namespace TheBeautyForum.Web.ViewModels.User
{
    public class EditProfileViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(FIRST_NAME_MAX_LENGTH, MinimumLength = FIRST_NAME_MIN_LENGTH)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(LAST_NAME_MAX_LENGTH, MinimumLength = LAST_NAME_MIN_LENGTH)]
        public string LastName { get; set; } = null!;

        public string? ProfilePictureUrl { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [EmailAddress]
        public string Email { get; set; } = null!;
    }
}
