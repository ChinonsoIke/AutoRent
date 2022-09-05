using AutoRent.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoRent.Models
{
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string DisplayName {
            get
            {
                // edit later tp display short name
                return $"{Make} {Trim}";
            }
        }
        public decimal RentPricePerDay { get; set; }
        public List<string> Images { get; set; }
        public string PlateNumber { get; set; }
        public int Mileage { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }
        public CarStatus Status { get; set; }


        public string LocationId { get; set; }
        public Location Location { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Rating> Ratings { get; set; }

    }
}
