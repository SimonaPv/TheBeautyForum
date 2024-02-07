using TheBeautyForum.Web.ViewModels.User;

namespace TheBeautyForum.Services.Users
{
    public interface IUserService
    {
        Task<ProfileViewModel> ShowProfileAsync(Guid userId);
    }
}