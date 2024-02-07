using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Publication;

namespace TheBeautyForum.Web.ViewModels.User
{
    public class ProfileViewModel
    {
        public Guid UserId { get; set; }

        public UserViewModel? User { get; set; } 
        
        public ICollection<AppointmentViewModel> Appointments { get; set; }
            = new HashSet<AppointmentViewModel>();

        public ICollection<PostForumViewModel> Publications { get; set; }
           = new HashSet<PostForumViewModel>();

        public ICollection<string> Images { get; set; }
           = new HashSet<string>();
    }
}
