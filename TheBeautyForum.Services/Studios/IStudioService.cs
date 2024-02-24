using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Services.Studios
{
    public interface IStudioService
    {
        Task<StudioProfileViewModel> ShowStudioProfileAsync(Guid studioId);
    }
}
