using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    public class StudioPostViewModel
    {
        public Guid Id { get; set; }

        public string StudioName { get; set; } = null!;
    }
}
