using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Web.ViewModels.Home;

namespace TheBeautyForum.Services.Home
{
    public interface IHomeService
    {
        Task<HomeViewModel> HomeAsync();
    }
}
