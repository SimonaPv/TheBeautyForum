using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Web.ViewModels.Appointment
{
    public class CreateAppointmentViewModel
    {
        public Guid CategoryId { get; set; }

        public Guid StudioId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string? Description { get; set; }

        public string? StudioPfp { get; set; }

        public TimeOnly StudioOpenTime { get; set; }

        public TimeOnly StudioCloseTime { get; set; }

        public ICollection<CategoryViewModel> Categories{ get; set; }
            = new HashSet<CategoryViewModel>();
    }
}
