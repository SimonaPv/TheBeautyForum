namespace TheBeautyForum.Web.Models
{
    /// <summary>
    /// Represents error view model.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets the request ID.
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// Gets or sets the show request ID.
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}