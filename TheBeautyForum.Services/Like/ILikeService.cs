namespace TheBeautyForum.Services.Like
{
    /// <summary>
    /// Provides access to likes.
    /// </summary>
    public interface ILikeService
    {
        /// <summary>
        /// Manage liking or disliking posts.
        /// </summary>
        /// <param name="postId">the ID of the post</param>
        /// <param name="userId">the ID of the user</param>
        Task HandleLikePostAsync(Guid postId, Guid userId);
    }
}
