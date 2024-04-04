namespace TheBeautyForum.Web.ViewModels.Rating
{
    /// <summary>
    /// Represents a rating view model.
    /// </summary>
    public class RatingViewModel
    {
        /// <summary>
        /// Gets or sets the rating ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the studio ID.
        /// </summary>
        public Guid StudioId { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public int Value { get; set; }
    }
}
