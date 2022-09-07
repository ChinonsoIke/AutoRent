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
        [Required]
        public string Id { get; set; }
        [Required]
        [StringLength(15)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(15)]
        public string LastName { get; set; }
        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(20)]
        public string Email { get; set; }
        [StringLength(10)]
        [Required]
        public string Password { get; set; }
        [StringLength(50)]
        [Required]
        public string HomeAddress { get; set; }
        [StringLength(30)]
        public string NextOfKin { get; set; }
        [StringLength(15)]
        public string NextOfKinContact { get; set; }
        [StringLength(50)]
        public string NextOfKinAddress { get; set; }
        public string DrivingLicenceImage { get; set; }
        public string UserImageUrl { get; set; }
        [Required]
        public bool Verified { get; set; }
        [Required]
        public bool CompletedRegistration { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
