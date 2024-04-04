using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBeautyForum.Data.Models
{
    /// <summary>
    /// Represents a like.
    /// </summary>
    public class Like
    {
        /// <summary>
        /// Get or sets the like ID.
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
        /// Get or sets the publication ID.
        /// </summary>
        [Required]
        [ForeignKey(nameof(Publication))]
        public Guid PublicationId { get; set; }

        /// <summary>
        /// Get or sets the user.
        /// </summary>
        public User? User { get; set; }

        /// <summary>
        /// Get or sets the publication.
        /// </summary>
        public Publication? Publication { get; set; }
    }
}
