using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Appointment;

namespace TheBeautyForum.Data.Models
{
    /// <summary>
    /// Represents an appointment.
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// Get or sets the appointment ID.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Get or sets the user ID.
        /// </summary>
        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        /// <summary>
        /// Get or sets the studio ID.
        /// </summary>
        [Required]
        [ForeignKey(nameof(Studio))]
        public Guid StudioId { get; set; }

        /// <summary>
        /// Get or sets the cateory ID.
        /// </summary>
        [Required]
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Get or sets the start date.
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Get or sets the end date.
        /// </summary>
        [Required]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Get or sets the description.
        /// </summary>
        [StringLength(DESCRIPTION_MAX_LENGTH)]
        public string? Description { get; set; }

        /// <summary>
        /// Get or sets the user.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Get or sets the studio.
        /// </summary>
        public Studio? Studio { get; set; }

        /// <summary>
        /// Get or sets the category.
        /// </summary>
        public Category? Category { get; set; }
    }
}
