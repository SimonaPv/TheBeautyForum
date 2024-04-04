using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Like;

namespace TheBeautyForum.Web.Controllers
{
    /// <summary>
    /// Represents the like controller.
    /// </summary>
    [Authorize]
    public class LikeController : Controller
    {
        private readonly ILikeService _likeService;

        /// <summary>
        /// Initialize new instance of <see cref="LikeController"/> class.
        /// </summary>
        /// <param name="likeService"></param>
        public LikeController(
            ILikeService likeService)
        {
            this._likeService = likeService;
        }

        /// <summary>
        /// Likes or dislikes publications.
        /// </summary>
        /// <param name="postId">the ID of the publication</param>
        [HttpPost]
        public async Task HandleLike(
            string postId)
        {
            await _likeService.HandleLikePostAsync(Guid.Parse(postId), Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));
        }
    }
}
