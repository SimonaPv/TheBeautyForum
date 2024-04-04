using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheBeautyForum.Data.Models
{
    /// <summary>
    /// Get or sets the studio category.
    /// </summary>
    public class StudioCategory
    {
        /// <summary>
        /// Get or sets the category ID.
        /// </summary>
        [Required]
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Get or sets the studio ID.
        /// </summary>
        [Required]
        [ForeignKey(nameof(Studio))]
        public Guid StudioId { get; set; }

        /// <summary>
        /// Get or sets the category.
        /// </summary>
        public Category? Category { get; set; }

        /// <summary>
        /// Get or sets the studio.
        /// </summary>
        public Studio? Studio { get; set; }
    }
}
