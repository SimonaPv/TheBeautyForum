namespace TheBeautyForum.Web.ViewModels.Studio
{
    public class StudioForumViewModel
    {
        public Guid StudioId { get; set; }

        public string StudioName { get; set; } = null!;

        public double? StudioRating { get; set; }

        public string? StudioProfilePic { get; set; }

        public string? StudioDescription { get; set; }
    }
}
