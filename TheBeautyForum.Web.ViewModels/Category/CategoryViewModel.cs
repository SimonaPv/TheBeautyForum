using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Category;

namespace TheBeautyForum.Web.ViewModels.Category
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(NAME_MAX_LENGTH, MinimumLength = NAME_MIN_LENGTH)]
        public string Name { get; set; } = null!;

        public bool IsSelected { get; set; }
    }
}
