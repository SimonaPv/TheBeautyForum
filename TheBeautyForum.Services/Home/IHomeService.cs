using TheBeautyForum.Web.ViewModels.Home;

namespace TheBeautyForum.Services.Home
{
    /// <summary>
    /// Provides access to home.
    /// </summary>
    public interface IHomeService
    {
        /// <summary>
        /// Returns studios and users count.
        /// </summary>
        /// <returns>Studios and users count.</returns>
        Task<HomeViewModel> HomeAsync();
    }
}
