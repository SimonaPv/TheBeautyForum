using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeautyForum.Services.Publication
{
    public class PublicationService : IPublicationService
    {
        private readonly IPublicationService _publicationService;

        public PublicationService(IPublicationService publicationService)
        {
            this._publicationService = publicationService;
        }

        public Task CreatePublicationAsync(Guid userId, Guid studioId)
        {
            throw new NotImplementedException();
        }
    }
}
