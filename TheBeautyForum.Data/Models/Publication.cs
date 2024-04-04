using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TheBeautyForum.Data.DataConstants.Publication;

namespace TheBeautyForum.Data.Models
{
    /// <summary>
    /// Represents publication.
    /// </summary>
    public class Publication
    {
        /// <summary>
        /// Get or sets the publication ID.
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
        /// Get or sets the description.
        /// </summary>
        [StringLength(DESCRIPTION_MAX_LENGTH)]
        public string? Description { get; set; }

        /// <summary>
        /// Get or sets the date and time that is posted the publication.
        /// </summary>
        public DateTime DatePosted { get; set; }

        /// <summary>
        /// Get or sets the user.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Get or sets the studio.
        /// </summary>
        public Studio? Studio { get; set; }

        /// <summary>
        /// Get or sets the image.
        /// </summary>
        public Image? Image { get; set; }

        /// <summary>
        /// Get or sets the likes.
        /// </summary>
        public ICollection<Like> Likes { get; set; }
           = new HashSet<Like>();
    }
}
