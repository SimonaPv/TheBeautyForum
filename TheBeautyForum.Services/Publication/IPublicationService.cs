using TheBeautyForum.Web.ViewModels.Publication;

namespace TheBeautyForum.Services.Publication
{
    public interface IPublicationService
    {
        Task<List<ForumViewModel>> ForumAsync(Guid userId);

        Task CreatePublicationAsync(CreatePublicationViewModel model, Guid userId);

        Task DeletePublicationAsync(Guid postId);
    }
}
