﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using static TheBeautyForum.Data.DataConstants.Studio;
using TheBeautyForum.Web.ViewModels.Category;
using Microsoft.AspNetCore.Http;

namespace TheBeautyForum.Web.ViewModels.Studio
{
    public class CreateStudioViewModel
    {
        [Required]
        [StringLength(NAME_MAX_LENGTH, MinimumLength = NAME_MIN_LENGTH)]
        public string Name { get; set; } = null!;

        public IFormFile? ProfilePicture { get; set; }

        [Required]
        public string OpenTime { get; set; } = null!;

        [Required]
        public string CloseTime { get; set; } = null!;

        [Required]
        [StringLength(DESCRIPTION_MAX_LENGTH, MinimumLength = DESCRIPTION_MIN_LENGTH)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(LOCATION_MAX_LENGTH, MinimumLength = LOCATION_MIN_LENGTH)]
        public string Location { get; set; } = null!;

        public List<Guid> CategoryIds { get; set; }
            = new List<Guid>();

        public List<CategoryViewModel> Categories { get; set; }
            = new List<CategoryViewModel>();
    }
}