namespace TheBeautyForum.Services.Like
{
    public interface ILikeService
    {
        Task HandleLikePostAsync(Guid postId, Guid userId);
    }
}
