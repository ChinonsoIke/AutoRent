using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent.Models
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { 
            get{ return $"{Area}, {State}"; }
        }
        public string StreetNumber { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        public List<Car> Cars { get; set; }
    }
}
