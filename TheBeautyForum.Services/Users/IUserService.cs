using TheBeautyForum.Web.ViewModels.User;

namespace TheBeautyForum.Services.Users
{
    public interface IUserService
    {
        Task<ProfileViewModel> ShowLoggedProfileAsync(Guid userId);

        Task<ProfileViewModel> ShowUserProfileAsync(Guid userId);

        Task EditUserProfileAsync(EditProfileViewModel model, Guid userId);

        Task<EditProfileViewModel> GetUserAsync(Guid userId);
    }
}