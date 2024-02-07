using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeautyForum.Web.ViewModels.Rating
{
    public class RatingViewModel
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid StudioId { get; set; }

        public int Value { get; set; }
    }
}
