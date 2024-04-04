namespace TheBeautyForum.Web.ViewModels.Studio
{
    /// <summary>
    /// Represents a studio user view model.
    /// </summary>
    public class StudioUserViewModel
    {
        /// <summary>
        /// Gets or sets the studio ID.
        /// </summary>
        public Guid StudioId { get; set; }

        /// <summary>
        /// Gets or sets the profile picture URL.
        /// </summary>
        public string? ProfilePicUrl { get; set; }

        /// <summary>
        /// Gets or sets the studio name.
        /// </summary>
        public string? StudioName { get; set; }

        /// <summary>
        /// Gets or sets the studio description.
        /// </summary>
        public string? StudioDescription { get; set; }

        /// <summary>
        /// Gets or sets the approval.
        /// </summary>
        public bool IsApproved { get; set; }

        /// <summary>
        /// Gets or sets the average rating.
        /// </summary>
        public int? RatingSum { get; set; }
    }
}
