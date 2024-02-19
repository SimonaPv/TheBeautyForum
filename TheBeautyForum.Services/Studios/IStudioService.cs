using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Web.ViewModels.Image;
using TheBeautyForum.Web.ViewModels.Studio;
using TheBeautyForum.Web.ViewModels.User;

namespace TheBeautyForum.Services.Studios
{
    public interface IStudioService
    {
        Task<StudioProfileViewModel> ShowStudioProfileAsync(Guid studioId);
    }
}
