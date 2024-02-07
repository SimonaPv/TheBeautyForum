using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeautyForum.Web.ViewModels.Publication
{
    public class PostForumViewModel
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid StudioId { get; set; }

        public string? Description { get; set; }

        public ICollection<string> ImageUrls { get; set; }
            = new HashSet<string>();
    }
}
