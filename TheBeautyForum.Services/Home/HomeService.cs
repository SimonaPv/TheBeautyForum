using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Home;

namespace TheBeautyForum.Services.Home
{
    /// <summary>
    /// Represents home service.
    /// </summary>
    public class HomeService : IHomeService
    {
        private readonly ApplicationDbContext _dbContext;

        /// <summary>
        /// Initialize a new instance of the <see cref="HomeService"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public HomeService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        /// <inheritdoc/>
        public async Task<HomeViewModel> HomeAsync()
        {
            var model = new HomeViewModel();

            model.StudiosCount = await _dbContext.Studios
                .CountAsync() + 100;
            model.UsersCount = await _dbContext.Users
                .CountAsync() + 200;

            return model;
        }
    }
}
