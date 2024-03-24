using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Services.Studios
{
    public interface IStudioService
    {
        Task<StudioProfileViewModel> ShowStudioProfileAsync(Guid studioId);

        Task<EditStudioProfileViewModel> GetStudioAsync(Guid studioId);

        Task EditStudioProfileAsync(EditStudioProfileViewModel model, Guid studioId);

        Task<List<ViewStudioViewModel>> GetAllStudiosAsync(FilterViewModel? filter = null);

        Task DeleteStudioAsync(Guid studioId);
    }
}
