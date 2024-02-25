using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheBeautyForum.Data.Models
{
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(Publication))]
        public Guid PublicationId { get; set; }

        [Required]
        public string UrlPath { get; set; } = null!;

        public Publication? Publication { get; set; }
    }
}
