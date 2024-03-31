using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TheBeautyForum.Data.DataConstants.Publication;

namespace TheBeautyForum.Data.Models
{
    public class Publication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [Required]
        [ForeignKey(nameof(Studio))]
        public Guid StudioId { get; set; }

        [StringLength(DESCRIPTION_MAX_LENGTH)]
        public string? Description { get; set; }

        public DateTime DatePosted { get; set; }

        public User? User { get; set; }

        public Studio? Studio { get; set; }

        public Image? Image { get; set; }

        public ICollection<Like> Likes { get; set; }
           = new HashSet<Like>();
    }
}
