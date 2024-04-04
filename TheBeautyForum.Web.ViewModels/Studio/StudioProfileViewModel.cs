using System.ComponentModel.DataAnnotations;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Publication;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    /// <summary>
    /// Represents a studio profile view model.
    /// </summary>
    public class StudioProfileViewModel
    {
        /// <summary>
        /// Gets or sets the studio ID.
        /// </summary>
        public Guid StudioId { get; set; }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the profile picture URL.
        /// </summary>
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// Gets or sets the average rating.
        /// </summary>
        public int? RatingSum { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public string Location { get; set; } = null!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Gets or sets the open time.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public TimeOnly OpenTime { get; set; }

        /// <summary>
        /// Gets or sets the close time.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public TimeOnly CloseTime { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        public ICollection<string> Images { get; set; } 
            = new HashSet<string>();

        /// <summary>
        /// Gets or sets the category names.
        /// </summary>
        public ICollection<string> CategoryNames { get; set; }
            = new HashSet<string>();

        /// <summary>
        /// Gets or sets the appointments.
        /// </summary>
        public ICollection<AppointmentViewModel> Appointments { get; set; }
            = new HashSet<AppointmentViewModel>();

        /// <summary>
        /// Gets or sets the publications.
        /// </summary>
        public List<PostForumViewModel> Publications { get; set; }
            = new List<PostForumViewModel>();
    }
}
