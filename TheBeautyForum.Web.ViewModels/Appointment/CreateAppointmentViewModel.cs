using System.ComponentModel.DataAnnotations;
using TheBeautyForum.Web.ViewModels.Category;
using static TheBeautyForum.Data.DataConstants.Appointment;

namespace TheBeautyForum.Web.ViewModels.Appointment
{
    public class CreateAppointmentViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        public Guid StudioId { get; set; }

        [Required]
        [StringLength(DESCRIPTION_MAX_LENGTH, MinimumLength = DESCRIPTION_MIN_LENGTH)]
        public string? Description { get; set; }

        public string? StudioPfp { get; set; }

        public int StartDateHour { get; set; }

        public TimeOnly StudioOpenTime { get; set; }

        public TimeOnly StudioCloseTime { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ICollection<CategoryViewModel> Categories{ get; set; }
            = new HashSet<CategoryViewModel>();
    }
}
