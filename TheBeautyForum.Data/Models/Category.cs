using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TheBeautyForum.Data.DataConstants.Category;

namespace TheBeautyForum.Data.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(NAME_MAX_LENGTH)]
        public string Name { get; set; } = null!;

        public ICollection<Appointment> Appointments { get; set; }
            = new HashSet<Appointment>();

        public ICollection<StudioCategory> CategoryStudios { get; set; }
           = new HashSet<StudioCategory>();
    }
}
