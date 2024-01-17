using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Rating;

namespace TheBeautyForum.Data.Models
{
    public class Rating
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
        [Range((double)RATING_MIN_VALUE, (double)RATING_MAX_VALUE)]
        public int Value { get; set; }

        public User? User { get; set; }

        public Studio? Studio { get; set; }
    }
}
