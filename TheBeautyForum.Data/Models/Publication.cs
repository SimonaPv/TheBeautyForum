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

        [Required]
        [StringLength(DESCRIPTION_MAX_LENGTH)]
        public string? Description { get; set; }

        [Required]
        [StringLength(IMAGE_MAX_LENGTH)]
        public string Image { get; set; } = null!;

        public User? User { get; set; }

        public Studio? Studio { get; set; }

        public ICollection<Comment> Comments { get; set; }
           = new HashSet<Comment>();

        public ICollection<Like> Likes { get; set; }
           = new HashSet<Like>();

        public ICollection<Image> Images { get; set; }
           = new HashSet<Image>();
    }
}
