namespace TheBeautyForum.Web.ViewModels.Studio
{
    /// <summary>
    /// Represents a studio forum view model.
    /// </summary>
    public class StudioForumViewModel
    {
        /// <summary>
        /// Gets or sets the studio ID.
        /// </summary>
        public Guid StudioId { get; set; }

        /// <summary>
        /// Gets or sets the studio name.
        /// </summary>
        public string StudioName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the studio rating.
        /// </summary>
        public double? StudioRating { get; set; }

        /// <summary>
        /// Gets or sets the studio profile picture.
        /// </summary>
        public string? StudioProfilePic { get; set; }

        /// <summary>
        /// Gets or sets the studio description.
        /// </summary>
        public string? StudioDescription { get; set; }
    }
}
