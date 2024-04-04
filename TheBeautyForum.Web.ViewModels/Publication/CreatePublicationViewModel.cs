using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Publication;
using TheBeautyForum.Web.ViewModels.Studio;
using Microsoft.AspNetCore.Http;

namespace TheBeautyForum.Web.ViewModels.Publication
{
    /// <summary>
    /// Represents a create publication view model.
    /// </summary>
    public class CreatePublicationViewModel
    {
        /// <summary>
        /// Gets or sets the studio ID.
        /// </summary>
        [Required]
        public Guid StudioId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [StringLength(DESCRIPTION_MAX_LENGTH, MinimumLength = DESCRIPTION_MIN_LENGTH)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        public IFormFile? Image { get; set; }

        /// <summary>
        /// Gets or sets the user first name.
        /// </summary>
        public string? UserFirstName { get; set; }

        /// <summary>
        /// Gets or sets the user last name.
        /// </summary>
        public string? UserLastName { get; set; }

        /// <summary>
        /// Gets or sets the user profile picture.
        /// </summary>
        public string? UserProfilePic { get; set; }

        /// <summary>
        /// Gets or sets the view URL.
        /// </summary>
        public string? ViewUrl { get; set; }

        /// <summary>
        /// Gets or sets the studios.
        /// </summary>
        public ICollection<StudioPostViewModel> Studios { get; set; }
            = new HashSet<StudioPostViewModel>();
    }
}
