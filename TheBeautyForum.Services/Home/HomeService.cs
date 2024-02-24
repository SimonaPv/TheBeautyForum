using Microsoft.EntityFrameworkCore;
using TheBeautyForum.Web.Data;
using TheBeautyForum.Web.ViewModels.Home;

namespace TheBeautyForum.Services.Home
{
    public class HomeService : IHomeService
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<HomeViewModel> HomeAsync()
        {
            var model = new HomeViewModel();

            model.StudiosCount = await _dbContext.Studios
                .CountAsync();
            model.UsersCount = await _dbContext.Users
                .CountAsync();

            return model;
        }
    }
}
