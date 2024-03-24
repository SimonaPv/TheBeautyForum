using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    public class ViewStudioViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string? ProfilePictureUrl { get; set; }

        public string OpenTime { get; set; } = null!;

        public string CloseTime { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Location { get; set; } = null!;

        public double? RatingSum { get; set; }

        public FilterViewModel? Filter { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
            = new List<CategoryViewModel>();
    }
}
