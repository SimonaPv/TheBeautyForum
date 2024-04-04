namespace TheBeautyForum.Web.ViewModels.User
{
    /// <summary>
    /// Represents an user view model.
    /// </summary>
    public class UserViewModel
    {
        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the profile picture URL.
        /// </summary>
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        public string? Role { get; set; }
    }
}
