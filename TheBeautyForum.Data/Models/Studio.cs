using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Studio;

namespace TheBeautyForum.Data.Models
{
    public class Studio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        //[Required]
        //[ForeignKey(nameof(User))]
        //public Guid UserId { get; set; }

        [Required]
        [StringLength(NAME_MAX_LENGTH)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DESCRIPTION_MAX_LENGTH)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(LOCATION_MAX_LENGTH)]
        public string Location { get; set; } = null!;

        [Required]
        public TimeOnly OpenTime { get; set; }

        [Required]
        public TimeOnly CloseTime { get; set; }

        public string? StudioPictureUrl { get; set; }

        //public User? User { get; set; }

        public ICollection<StudioCategory> StudioCategories { get; set; }
            = new HashSet<StudioCategory>();

        public ICollection<Appointment> Appointments { get; set; }
            = new HashSet<Appointment>();

        public ICollection<Rating> Ratings { get; set; }
            = new HashSet<Rating>();

        public ICollection<Publication> Publications { get; set; }
            = new HashSet<Publication>();
    }
}
