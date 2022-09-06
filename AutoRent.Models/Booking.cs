using AutoRent.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoRent.Models
{
    public class Booking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public DateTime PickUpDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal PriceTotal { get; set; }
        public BookingStatus BookingStatus { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        public string CarId { get; set; }
        public Car Car { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public Payment Payment { get; set; }
    }
}
