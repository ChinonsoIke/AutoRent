using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoRent.Models
{
    public class Rating
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Stars { get; set; }
        public string Review { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
        public string CarId { get; set; }
        public Car Car { get; set; }
    }
}
