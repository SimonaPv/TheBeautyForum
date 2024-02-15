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

        public string? UserFirstName { get; set; }

        public string? UserLastName { get; set; }

        public string? UserProfilePic { get; set; }

        public Guid PostUserId { get; set; }

        public Guid StudioId { get; set; }

        public string? PostUserProfilePic { get; set; }

        public string? UserName { get; set; }

        public string? StudioName { get; set; }

        public string? Description { get; set; }

        public int LikeCount { get; set; }

        public int CommentCount { get; set; }

        public DateTime DatePosted { get; set; }

        public ICollection<string> StudiosNames { get; set; }
            = new List<string>();

        public ICollection<string> Images { get; set; }
           = new HashSet<string>();
    }
}
