namespace TheBeautyForum.Web.ViewModels.Studio
{
    /// <summary>
    /// Represents a studio publication view model.
    /// </summary>
    public class StudioPostViewModel
    {
        /// <summary>
        /// Gets or sets the studio ID.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the studio name.
        /// </summary>
        public string StudioName { get; set; } = null!;
    }
}
