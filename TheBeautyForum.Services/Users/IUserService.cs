using TheBeautyForum.Web.ViewModels.User;

namespace TheBeautyForum.Services.Users
{
    /// <summary>
    /// Provides access to users.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Shows the logged user profile.
        /// </summary>
        /// <param name="userId">the ID of the user</param>
        /// <returns>The profile of the logged user.</returns>
        Task<ProfileViewModel> ShowLoggedProfileAsync(Guid userId);

        /// <summary>
        /// Shows the admin user profile.
        /// </summary>
        /// <param name="userId">the ID of the user</param>
        /// <returns>The profile of the admin.</returns>
        Task<ProfileViewModel> ShowAdminProfileAsync(Guid userId);

        /// <summary>
        /// Shows the studio creator profile.
        /// </summary>
        /// <param name="userId">the ID of the user</param>
        /// <returns>The profile of the studio creator.</returns>
        Task<ProfileViewModel> ShowStudioCreatorLoggedProfileAsync(Guid userId);

        /// <summary>
        /// Shows the user profile.
        /// </summary>
        /// <param name="userId">the ID of the user</param>
        /// <param name="loggedUserId">the ID of the logged user</param>
        /// <returns>The profile of the user.</returns>
        Task<ProfileViewModel> ShowUserProfileAsync(Guid userId, Guid loggedUserId);

        /// <summary>
        /// Edits the profile of the user.
        /// </summary>
        /// <param name="model">the model for editing the profile</param>
        /// <param name="userId">the ID of the user</param>
        Task EditUserProfileAsync(EditProfileViewModel model, Guid userId);

        /// <summary>
        /// Gets user by ID.
        /// </summary>
        /// <param name="userId">the ID of the user</param>
        /// <returns>The user's profile.</returns>
        Task<EditProfileViewModel> GetUserAsync(Guid userId);

        /// <summary>
        /// Approves studio by admin.
        /// </summary>
        /// <param name="studioId">the ID of the studio</param>
        Task ApproveStudioAsync(Guid studioId);

        /// <summary>
        /// Declines studio by admin.
        /// </summary>
        /// <param name="studioId">the ID of the studio</param>
        Task DeclineStudioAsync(Guid studioId);
    }
}