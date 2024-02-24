using TheBeautyForum.Web.ViewModels.Home;

namespace TheBeautyForum.Services.Home
{
    public interface IHomeService
    {
        Task<HomeViewModel> HomeAsync();
    }
}
