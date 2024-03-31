using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Publication;
using TheBeautyForum.Web.ViewModels.Studio;
using Microsoft.AspNetCore.Http;

namespace TheBeautyForum.Web.ViewModels.Publication
{
    public class CreatePublicationViewModel
    {
        [Required]
        public Guid StudioId { get; set; }

        [StringLength(DESCRIPTION_MAX_LENGTH, MinimumLength = DESCRIPTION_MIN_LENGTH)]
        public string? Description { get; set; }

        public IFormFile? Image { get; set; }

        public string? UserFirstName { get; set; }

        public string? UserLastName { get; set; }

        public string? UserProfilePic { get; set; }

        public string? ViewUrl { get; set; }

        public ICollection<StudioPostViewModel> Studios { get; set; }
            = new HashSet<StudioPostViewModel>();
    }
}
