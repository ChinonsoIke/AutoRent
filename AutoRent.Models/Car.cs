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
        public string Name { get; set; }
        public decimal RentPricePerDay { get; set; }
        public string PlateNumber { get; set; }
        public string Mileage { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }
        public CarStatus Status { get; set; }


        public string LocationId { get; set; }
        public Location Location { get; set; }
        // add List<Booking> when booking model is created
        // add List<Image> when image model created
        // add List<Rating> when rating model is created

    }
}
