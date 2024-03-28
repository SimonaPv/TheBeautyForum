using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.User;

namespace TheBeautyForum.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        [Required]
        [StringLength(FIRST_NAME_MAX_LENGTH)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LAST_NAME_MAX_LENGTH)]
        public string LastName { get; set; } = null!;

        public string UserRole { get; set; } = null!;

        public string? ProfilePictureUrl { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
            = new HashSet<Appointment>();

        public ICollection<Like> Likes { get; set; }
            = new HashSet<Like>();

        public ICollection<Studio> Studios { get; set; }
            = new HashSet<Studio>();

        public ICollection<Rating> Ratings { get; set; }
            = new HashSet<Rating>();

        public ICollection<Publication> Publications { get; set; }
            = new HashSet<Publication>();
    }
}