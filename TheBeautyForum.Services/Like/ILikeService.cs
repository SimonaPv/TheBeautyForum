using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeautyForum.Services.Like
{
    public interface ILikeService
    {
        Task HandleLikePostAsync(Guid postId, Guid userId);
    }
}
