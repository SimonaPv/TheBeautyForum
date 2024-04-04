using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheBeautyForum.Data.Models
{
    /// <summary>
    /// Represents an image.
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Get or sets image ID.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Get or sets the publication ID.
        /// </summary>
        [Required]
        [ForeignKey(nameof(Publication))]
        public Guid PublicationId { get; set; }

        /// <summary>
        /// Get or sets the url path.
        /// </summary>
        [Required]
        public string UrlPath { get; set; } = null!;

        /// <summary>
        /// Get or sets the publication.
        /// </summary>
        public Publication? Publication { get; set; }
    }
}
