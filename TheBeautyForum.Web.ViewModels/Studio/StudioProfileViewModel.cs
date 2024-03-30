using System.ComponentModel.DataAnnotations;
using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Publication;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    public class StudioProfileViewModel
    {
        public Guid StudioId { get; set; }

        public Guid UserId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public string? ProfilePictureUrl { get; set; }

        public int? RatingSum { get; set; }

        [Required]
        public string Location { get; set; } = null!;

        [Required]
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

        public List<PostForumViewModel> Publications { get; set; }
            = new List<PostForumViewModel>();
    }
}
