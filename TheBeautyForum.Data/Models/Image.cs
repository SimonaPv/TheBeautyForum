﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBeautyForum.Data.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? UrlPath { get; set; }

        [ForeignKey(nameof(Publication))]
        public Guid PublicationId { get; set; }

        public Publication? Publication { get; set; }
    }
}
