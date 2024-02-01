using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeautyForum.Web.ViewModels.Image
{
    public class ForumViewModel
    {
        public Guid PublicationId { get; set; }

        public Guid UserId { get; set; }

        public Guid StudioId { get; set; }

        public string? UrlPath { get; set; }

        public string? UserProfilePic { get; set; }

        public string? UserName { get; set; }

        public string? Description { get; set; }

        public int LikeCount { get; set; }

        public int CommentCount { get; set; }

        public ICollection<string> StudiosNames { get; set; }
            = new List<string>();
    }
}
