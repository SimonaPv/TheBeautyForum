using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    public class FilterViewModel
    {
        public string? Location { get; set; }
        
        public string? Category { get; set; }

        public string? Rating { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
            = new List<CategoryViewModel>();

        public ICollection<string> Locations { get; set; }
            = new HashSet<string>();
    }
}
