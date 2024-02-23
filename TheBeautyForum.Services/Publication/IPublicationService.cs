using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Web.ViewModels.Publication;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Services.Publication
{
    public interface IPublicationService
    {
        Task<CreatePublicationViewModel> LoadAllStudiosAsync(Guid userId);

        Task CreatePublicationAsync(CreatePublicationViewModel model, Guid userId);
    }
}
