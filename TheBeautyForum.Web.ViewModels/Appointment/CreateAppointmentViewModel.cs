using System.ComponentModel.DataAnnotations;
using TheBeautyForum.Web.ViewModels.Category;
using static TheBeautyForum.Data.DataConstants.Appointment;

namespace TheBeautyForum.Web.ViewModels.Appointment
{
    /// <summary>
    /// Represents a create appointment view model.
    /// </summary>
    public class CreateAppointmentViewModel
    {
        /// <summary>
        /// Gets or sets the appointment ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the category ID.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the studio ID.
        /// </summary>
        public Guid StudioId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(DESCRIPTION_MAX_LENGTH, MinimumLength = DESCRIPTION_MIN_LENGTH)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the studio profile picture URL.
        /// </summary>
        public string? StudioPfp { get; set; }

        /// <summary>
        /// Gets or sets the start date hour of the appointment.
        /// </summary>
        public int StartDateHour { get; set; }

        /// <summary>
        /// Gets or sets the studio open time.
        /// </summary>
        public string? StudioOpenTime { get; set; }

        /// <summary>
        /// Gets or sets the studio close time.
        /// </summary>
        public string? StudioCloseTime { get; set; }

        /// <summary>
        /// Gets or sets the start date of the appointment.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of the appointment.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public ICollection<CategoryViewModel> Categories { get; set; }
            = new HashSet<CategoryViewModel>();
    }
}
