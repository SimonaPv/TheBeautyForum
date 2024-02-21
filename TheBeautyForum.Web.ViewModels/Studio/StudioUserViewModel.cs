﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    public class StudioUserViewModel
    {
        public Guid StudioId { get; set; }

        public string? ProfilePicUrl { get; set; }

        public string? StudioName { get; set; }

        public string? StudioDescription { get; set; }
    }
}