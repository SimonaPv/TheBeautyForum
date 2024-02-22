using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeautyForum.Services.Publication
{
    public interface IPublicationService
    {
        Task CreatePublicationAsync(Guid userId, Guid studioId);
    }
}
