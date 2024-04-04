using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Studio;

namespace TheBeautyForum.Data.Models
{
    /// <summary>
    /// Represents a studio.
    /// </summary>
    public class Studio
    {
        /// <summary>
        /// Get or sets the studio ID.
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
        /// Get or sets the name.
        /// </summary>
        [Required]
        [StringLength(NAME_MAX_LENGTH)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Get or sets the description.
        /// </summary>
        [Required]
        [StringLength(DESCRIPTION_MAX_LENGTH)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Get or sets the location.
        /// </summary>
        [Required]
        [StringLength(LOCATION_MAX_LENGTH)]
        public string Location { get; set; } = null!;

        /// <summary>
        /// Get or sets the open time.
        /// </summary>
        [Required]
        public TimeOnly OpenTime { get; set; }

        /// <summary>
        /// Get or sets the close time.
        /// </summary>
        [Required]
        public TimeOnly CloseTime { get; set; }

        /// <summary>
        /// Get or sets the profile picture URL.
        /// </summary>
        public string? StudioPictureUrl { get; set; }

        /// <summary>
        /// Get or sets the approval.
        /// </summary>
        public bool IsApproved { get; set; }

        /// <summary>
        /// Get or sets the user.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Get or sets the studio categories.
        /// </summary>
        public ICollection<StudioCategory> StudioCategories { get; set; }
            = new HashSet<StudioCategory>();

        /// <summary>
        /// Get or sets the appointments.
        /// </summary>
        public ICollection<Appointment> Appointments { get; set; }
            = new HashSet<Appointment>();

        /// <summary>
        /// Get or sets the ratings.
        /// </summary>
        public ICollection<Rating> Ratings { get; set; }
            = new HashSet<Rating>();

        /// <summary>
        /// Get or sets the publications.
        /// </summary>
        public ICollection<Publication> Publications { get; set; }
            = new HashSet<Publication>();
    }
}
