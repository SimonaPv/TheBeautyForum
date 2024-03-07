namespace TheBeautyForum.Web.ViewModels.Publication
{
    public class PostForumViewModel
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid StudioId { get; set; }

        public DateTime DatePosted { get; set; }

        public string? StudioName { get; set; }

        public string? UserName { get; set; }
        
        public string? ProfilePicUrl { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}
