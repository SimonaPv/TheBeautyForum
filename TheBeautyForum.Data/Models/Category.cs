using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TheBeautyForum.Data.DataConstants.Category;

namespace TheBeautyForum.Data.Models
{
    /// <summary>
    /// Represents a category.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Get or sets the category ID.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Get or sets the name.
        /// </summary>
        [Required]
        [StringLength(NAME_MAX_LENGTH)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Get or sets the appointments.
        /// </summary>
        public ICollection<Appointment> Appointments { get; set; }
            = new HashSet<Appointment>();

        /// <summary>
        /// Get or sets the category studios.
        /// </summary>
        public ICollection<StudioCategory> CategoryStudios { get; set; }
           = new HashSet<StudioCategory>();
    }
}
