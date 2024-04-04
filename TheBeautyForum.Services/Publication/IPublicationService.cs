using TheBeautyForum.Web.ViewModels.Publication;

namespace TheBeautyForum.Services.Publication
{
    /// <summary>
    /// Provides access to publications.
    /// </summary>
    public interface IPublicationService
    {
        /// <summary>
        /// Shows the forum.
        /// </summary>
        /// <param name="userId">the ID of the user</param>
        /// <returns>Data for the forum.</returns>
        Task<List<ForumViewModel>> ForumAsync(Guid userId);

        /// <summary>
        /// Creates publication.
        /// </summary>
        /// <param name="model">the model for creating the publication</param>
        /// <param name="userId">the ID of the user</param>
        Task CreatePublicationAsync(CreatePublicationViewModel model, Guid userId);

        /// <summary>
        /// Deletes publication.
        /// </summary>
        /// <param name="postId">the ID of the post</param>
        Task DeletePublicationAsync(Guid postId);
    }
}
