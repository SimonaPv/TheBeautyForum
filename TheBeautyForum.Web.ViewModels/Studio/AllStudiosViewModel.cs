using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBeautyForum.Data.Models;
using TheBeautyForum.Web.ViewModels.Category;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    public class AllStudiosViewModel
    {
        public string? Location { get; set; }

        public string? Category { get; set; }

        public string? Rating { get; set; }

        public List<ViewStudioViewModel> Studios { get; set; }
            = new List<ViewStudioViewModel>();

        public List<CategoryViewModel> Categories { get; set; }
            = new List<CategoryViewModel>();

        public List<string> Locations { get; set; }
            = new List<string>();
    }
}
