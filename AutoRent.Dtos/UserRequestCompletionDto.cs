using System;
using System.Collections.Generic;
using System.Text;

namespace AutoRent.Dtos
{
    public class UserRequestCompletionDto
    {
        public string Id { get; set; }
        public string HomeAddress { get; set; }
        public string NextOfKin { get; set; }
        public string AddressNextOfKin { get; set; }
        public string ContactNextOfKin { get; set; }
        public string DrivingLicenceImage { get; set; }
        public string UserImage { get; set; }

    }
}
