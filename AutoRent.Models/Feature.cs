using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoRent.Models
{
    public class Feature
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<CarFeature> CarFeatures { get; set; }
    }
}
