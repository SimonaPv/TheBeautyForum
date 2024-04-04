using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Category;
using TheBeautyForum.Web.ViewModels.Publication;
using TheBeautyForum.Web.ViewModels.Rating;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Web.ViewModels.User
{
    /// <summary>
    /// Represents an user profile view model.
    /// </summary>
    public class ProfileViewModel
    {
        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public Guid UserId { get; set; }

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
        /// Gets or sets the publication.
        /// </summary>
        public CreatePublicationViewModel? Post { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public ICollection<CategoryViewModel> Categories { get; set; }
            = new HashSet<CategoryViewModel>();

        /// <summary>
        /// Gets or sets the favorite studios.
        /// </summary>
        public ICollection<StudioUserViewModel> FavoriteStudios { get; set; }
            = new HashSet<StudioUserViewModel>();

        /// <summary>
        /// Gets or sets the appointments.
        /// </summary>
        public ICollection<AppointmentViewModel> Appointments { get; set; }
            = new HashSet<AppointmentViewModel>();

        /// <summary>
        /// Gets or sets the ratings.
        /// </summary>
        public ICollection<RatingViewModel> Ratings { get; set; }
            = new HashSet<RatingViewModel>();

        /// <summary>
        /// Gets or sets the publications.
        /// </summary>
        public List<PostForumViewModel> Publications { get; set; }
            = new List<PostForumViewModel>();

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        public ICollection<UserViewModel> Users { get; set; }
            = new HashSet<UserViewModel>();

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        public ICollection<string> Images { get; set; }
            = new HashSet<string>();
    }
}
