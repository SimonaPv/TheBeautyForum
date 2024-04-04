using TheBeautyForum.Web.ViewModels.Rating;

namespace TheBeautyForum.Web.ViewModels.Appointment
{
    /// <summary>
    /// Represents an appointment view model.
    /// </summary>
    public class AppointmentViewModel
    {
        /// <summary>
        /// Gets or sets the appointment ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the studio ID.
        /// </summary>
        public Guid StudioId { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        public string? CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the studio name.
        /// </summary>
        public string? StudioName { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        public RatingViewModel? Rating { get; set; }
    }
}
