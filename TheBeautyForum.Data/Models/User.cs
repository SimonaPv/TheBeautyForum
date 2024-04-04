using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.User;

namespace TheBeautyForum.Data.Models
{
    /// <summary>
    /// Represents the user.
    /// </summary>
    public class User : IdentityUser<Guid>
    {
        /// <summary>
        /// Get or sets the first name.
        /// </summary>
        [Required]
        [StringLength(FIRST_NAME_MAX_LENGTH)]
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Get or sets the last name.
        /// </summary>
        [Required]
        [StringLength(LAST_NAME_MAX_LENGTH)]
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Get or sets the user role.
        /// </summary>
        public string UserRole { get; set; } = null!;

        /// <summary>
        /// Get or sets the profile picture URL.
        /// </summary>
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// Get or sets the appointments.
        /// </summary>
        public ICollection<Appointment> Appointments { get; set; }
            = new HashSet<Appointment>();

        /// <summary>
        /// Get or sets the likes.
        /// </summary>
        public ICollection<Like> Likes { get; set; }
            = new HashSet<Like>();

        /// <summary>
        /// Get or sets the studios.
        /// </summary>
        public ICollection<Studio> Studios { get; set; }
            = new HashSet<Studio>();

        /// <summary>
        /// Get or sets the ratings.
        /// </summary>
        public ICollection<Rating> Ratings { get; set; }
            = new HashSet<Rating>();

        /// <summary>
        /// Get or sets the publications.
        /// </summary>
        public ICollection<Publication> Publications { get; set; }
            = new HashSet<Publication>();
    }
}