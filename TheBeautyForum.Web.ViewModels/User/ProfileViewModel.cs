using TheBeautyForum.Web.ViewModels.Appointment;
using TheBeautyForum.Web.ViewModels.Publication;
using TheBeautyForum.Web.ViewModels.Rating;
using TheBeautyForum.Web.ViewModels.Studio;

namespace TheBeautyForum.Web.ViewModels.User
{
    public class ProfileViewModel
    {
        public Guid UserId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? ProfilePictureUrl { get; set; }

        public string? Email { get; set; }

        public ICollection<StudioUserViewModel> FavoriteStudios { get; set; }
            = new HashSet<StudioUserViewModel>();

        public ICollection<AppointmentViewModel> Appointments { get; set; }
            = new HashSet<AppointmentViewModel>();

        public ICollection<RatingViewModel> Ratings { get; set; }
            = new HashSet<RatingViewModel>();

        public ICollection<PostForumViewModel> Publications { get; set; }
            = new HashSet<PostForumViewModel>();

        public ICollection<string> Images { get; set; }
            = new HashSet<string>();
    }
}
