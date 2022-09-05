using System;
using System.Collections.Generic;
using System.Text;

namespace AutoRent.Models
{
    public class CarFeature
    {
        public string CarId { get; set; }
        public Car Car { get; set; }

        public string FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}
