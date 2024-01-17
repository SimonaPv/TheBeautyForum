using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Comment;

namespace TheBeautyForum.Data.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [Required]
        [ForeignKey(nameof(Publication))]
        public Guid PublicationId { get; set; }

        [Required]
        [StringLength(DESCRIPTION_MAX_LENGTH)]
        public string Description { get; set; } = null!;

        public User? User { get; set; }

        public Publication? Publication { get; set; }
    }
}
