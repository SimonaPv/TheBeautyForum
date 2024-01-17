using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheBeautyForum.Data.Models
{
    public class StudioCategory
    {
        [Required]
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(Studio))]
        public Guid StudioId { get; set; }

        public Category? Category { get; set; }

        public Studio? Studio { get; set; }
    }
}
