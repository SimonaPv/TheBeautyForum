using TheBeautyForum.Web.ViewModels.Rating;

namespace TheBeautyForum.Web.ViewModels.Appointment
{
    public class AppointmentViewModel
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid StudioId { get; set; }

        public RatingViewModel Rating { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string? Description { get; set; }

        public string? CategoryName { get; set; }

        public string? StudioName { get; set; }

        public string? UserName { get; set; }
    }
}
