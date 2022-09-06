using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoRent.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string HomeAddress { get; set; }
        public string NextOfKin { get; set; }
        public string NextOfKinContact { get; set; }
        public string NextOfKinAddress { get; set; }
        public string DrivingLicenceImage { get; set; }
        public string UserImageUrl { get; set; }
        public bool Verified { get; set; }
        public bool CompletedRegistration { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
