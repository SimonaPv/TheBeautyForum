using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Studio;
using TheBeautyForum.Web.ViewModels.Category;
using Microsoft.AspNetCore.Http;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    public class CreateStudioViewModel
    {
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(NAME_MAX_LENGTH, MinimumLength = NAME_MIN_LENGTH)]
        public string Name { get; set; } = null!;

        public IFormFile? ProfilePicture { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string OpenTime { get; set; } = null!;

        [Required(ErrorMessage = "This field is required.")] 
        public string CloseTime { get; set; } = null!;

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(DESCRIPTION_MAX_LENGTH, MinimumLength = DESCRIPTION_MIN_LENGTH)]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(LOCATION_MAX_LENGTH, MinimumLength = LOCATION_MIN_LENGTH)]
        public string Location { get; set; } = null!;

        [Required(ErrorMessage = "This field is required.")]
        public List<Guid> CategoryIds { get; set; }
            = new List<Guid>();

        [Required(ErrorMessage = "This field is required.")]
        public List<CategoryViewModel> Categories { get; set; }
            = new List<CategoryViewModel>();
    }
}
