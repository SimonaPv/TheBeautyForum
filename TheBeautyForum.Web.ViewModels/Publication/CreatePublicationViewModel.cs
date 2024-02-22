using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static TheBeautyForum.Data.DataConstants.Publication;

namespace TheBeautyForum.Web.ViewModels.Publication
{
    public class CreatePublicationViewModel
    {
        [Required]
        [StringLength(DESCRIPTION_MAX_LENGTH)]
        public string? Description { get; set; }


    }
}
