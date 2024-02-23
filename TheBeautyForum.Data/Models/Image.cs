using System;
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
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(Publication))]
        public Guid PublicationId { get; set; }

        [Required]
        public string UrlPath { get; set; } = null!;

        public Publication? Publication { get; set; }
    }
}
