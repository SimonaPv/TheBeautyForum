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
using static TheBeautyForum.Data.DataConstants.User;

namespace TheBeautyForum.Web.ViewModels.User
{
    public class UserViewModel
    {
        [Required]
        [StringLength(FIRST_NAME_MAX_LENGTH)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LAST_NAME_MAX_LENGTH)]
        public string LastName { get; set; } = null!;

        public string? ProfilePictureUrl { get; set; }

        public string? Email { get; set; }

        public ICollection<AppointmentViewModel> Appointments { get; set; }
            = new HashSet<AppointmentViewModel>();

        public ICollection<RatingViewModel> Ratings { get; set; }
            = new HashSet<RatingViewModel>();

        public ICollection<PostForumViewModel> Publications { get; set; }
            = new HashSet<PostForumViewModel>();
    }
}
