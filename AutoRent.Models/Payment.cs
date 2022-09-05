using AutoRent.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoRent.Models
{
    public class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }        
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
        public string BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
