using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Web.Data;

namespace TheBeautyForum.Services.Like
{
    public class LikeService : ILikeService
    {
        private readonly ApplicationDbContext _dbContext;

        public LikeService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task HandleLikePostAsync(Guid postId, Guid userId)
        {
            var model = await _dbContext.Users.Include(x => x.Likes).FirstOrDefaultAsync(x => x.Id == userId);

            if (model!= null && !model.Likes.Select(x => x.PublicationId).Contains(postId))
            {
                var like = new Data.Models.Like()
                {
                    Id = Guid.NewGuid(),
                    PublicationId = postId,
                    UserId = userId
                };

                await _dbContext.Likes.AddAsync(like);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                var like = await _dbContext.Likes.FirstOrDefaultAsync(x => x.PublicationId == postId && x.UserId == userId);

                if (like == null)
                {
                    throw new ArgumentNullException(nameof(like));
                }

                _dbContext.Likes.Remove(like);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
