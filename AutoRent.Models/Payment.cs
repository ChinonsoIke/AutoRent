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
        public PaymentOption Option;
        public Status Status;        
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        public User UserId { get; set; }
        // add User prop when user model is created
        public Booking BookingId { get; set; }
        // add Booking prop when user model is created
    }
}
