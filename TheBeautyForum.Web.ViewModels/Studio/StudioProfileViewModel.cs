using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Publication;
using TheBeautyForum.Web.ViewModels.Rating;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    public class StudioProfileViewModel
    {
        public Guid StudioId { get; set; }

        public string Name { get; set; } = null!;

        public string? ProfilePictureUrl { get; set; }

        public int? RatingSum { get; set; }

        public string Location { get; set; } = null!;

        public string Description { get; set; } = null!;

        [Required]
        public TimeOnly OpenTime { get; set; }

        [Required]
        public TimeOnly CloseTime { get; set; }

        public ICollection<string> Images { get; set; } 
            = new HashSet<string>();

        public ICollection<string> CategoryNames { get; set; }
            = new HashSet<string>();

        public ICollection<AppointmentViewModel> Appointments { get; set; }
            = new HashSet<AppointmentViewModel>();

        public ICollection<PostForumViewModel> Publications { get; set; }
            = new HashSet<PostForumViewModel>();
    }
}
