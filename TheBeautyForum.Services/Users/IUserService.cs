using TheBeautyForum.Web.ViewModels.User;

namespace TheBeautyForum.Services.Users
{
    public interface IUserService
    {
        Task<ProfileViewModel> ShowLoggedProfileAsync(Guid userId);

        Task<ProfileViewModel> ShowUserProfileAsync(Guid userId);
    }
}