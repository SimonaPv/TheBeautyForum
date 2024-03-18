using TheBeautyForum.Web.ViewModels.Category;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Services.Studios
{
    public interface IStudioService
    {
        Task<StudioProfileViewModel> ShowStudioProfileAsync(Guid studioId);

        Task<EditStudioProfileViewModel> GetStudioAsync(Guid studioId);

        Task EditStudioProfileAsync(EditStudioProfileViewModel model, Guid studioId);

        Task <AllStudiosViewModel> GetAllStudiosAsync();

        Task<AllStudiosViewModel> FilterByLocationAsync(string loc);

        Task<AllStudiosViewModel> FilterByProcedureAsync(string proc);

        Task<AllStudiosViewModel> FilterByRatingAsync(string method);
    }
}
