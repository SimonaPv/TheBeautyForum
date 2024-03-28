using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TheBeautyForum.Services.Like;

namespace TheBeautyForum.Web.Controllers
{
    public class LikeController : Controller
    {
        private readonly ILikeService _likeService;

        public LikeController(ILikeService likeService)
        {
            this._likeService = likeService;
        }

        [HttpPost]
        public async Task HandleLike(string postId)
        {
            await _likeService.HandleLikePostAsync(Guid.Parse(postId), Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)));
        }
    }
}
