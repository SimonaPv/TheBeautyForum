using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Rating;

namespace TheBeautyForum.Data.Models
{
    /// <summary>
    /// Represents rating.
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// Get or sets the rating ID.
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
        /// Get or sets the value.
        /// </summary>
        [Required]
        [Range((double)RATING_MIN_VALUE, (double)RATING_MAX_VALUE)]
        public int Value { get; set; }

        /// <summary>
        /// Get or sets the user.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Get or sets the studio.
        /// </summary>
        public Studio? Studio { get; set; }
    }
}
