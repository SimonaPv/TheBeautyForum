using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Category;

namespace TheBeautyForum.Web.ViewModels.Category
{
    /// <summary>
    /// Represents a category view model.
    /// </summary>
    public class CategoryViewModel
    {
        /// <summary>
        /// Gets or sets the category ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(NAME_MAX_LENGTH, MinimumLength = NAME_MIN_LENGTH)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the selected category.
        /// </summary>
        public bool IsSelected { get; set; }
    }
}
