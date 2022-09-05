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
        public string NextOfKinContact { get; set; }
        public string NextOfKinAddress { get; set; }
        public string DriverLicenceImage { get; set; }
        public string UserImageUrl { get; set; }
    }
}
