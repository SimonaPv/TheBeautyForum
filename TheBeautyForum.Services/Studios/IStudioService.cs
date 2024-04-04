using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Services.Studios
{
    /// <summary>
    /// Provides access to studios.
    /// </summary>
    public interface IStudioService
    {
        /// <summary>
        /// Returns the studio profile.
        /// </summary>
        /// <param name="studioId">the ID of the studio.</param>
        /// <param name="userId">the ID of the user</param>
        /// <returns>The studio profile.</returns>
        Task<StudioProfileViewModel> ShowStudioProfileAsync(Guid studioId, Guid userId);

        /// <summary>
        /// Gets studio by ID.
        /// </summary>
        /// <param name="studioId">the ID of the studio.</param>
        /// <returns>The studio.</returns>
        Task<EditStudioProfileViewModel> GetStudioAsync(Guid studioId);

        /// <summary>
        /// Edits studio.
        /// </summary>
        /// <param name="model">the model for editing the studio.</param>
        /// <param name="studioId">the ID of the studio</param>
        Task EditStudioProfileAsync(EditStudioProfileViewModel model, Guid studioId);

        /// <summary>
        /// Gets all studios.
        /// </summary>
        /// <param name="filter">the model for filtering the studios</param>
        /// <returns>List of studios.</returns>
        Task<List<ViewStudioViewModel>> GetAllStudiosAsync(FilterViewModel? filter = null);

        /// <summary>
        /// Deletes studio by ID.
        /// </summary>
        /// <param name="studioId">the ID of the studio.</param>
        Task DeleteStudioAsync(Guid studioId);

        /// <summary>
        /// Creates studio.
        /// </summary>
        /// <param name="model">the model for creating he studio</param>
        /// <param name="userId">the ID of the user</param>
        Task CreateStudioAsync(CreateStudioViewModel model, Guid userId);

        /// <summary>
        /// Loads all categories.
        /// </summary>
        /// <returns>EMpty studio with all categories.</returns>
        Task<CreateStudioViewModel> CreateStudioCategoriesAsync();
    }
}
