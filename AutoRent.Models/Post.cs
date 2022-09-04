using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoRent.Models
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(10)]
        public string Body { get; set; }
        [MaxLength(100)]
        public string FeaturedImage { get; set; }
    }
}
