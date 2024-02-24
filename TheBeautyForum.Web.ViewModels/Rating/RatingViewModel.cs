namespace TheBeautyForum.Web.ViewModels.Rating
{
    public class RatingViewModel
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid StudioId { get; set; }

        public int Value { get; set; }
    }
}
