using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent.Models
{
    public class Location
    {
        public string Id { get; set; }
        public string Name { 
            get{ return $"{Area}, {State}"; }
        }
        public string StreetNumber { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
