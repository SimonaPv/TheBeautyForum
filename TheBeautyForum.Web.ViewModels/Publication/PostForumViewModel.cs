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

        public DateTime DatePosted { get; set; }

        public string? StudioName { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}
