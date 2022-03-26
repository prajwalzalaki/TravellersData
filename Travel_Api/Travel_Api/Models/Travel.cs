using System;
using System.Collections.Generic;

namespace Travel_Api.Models
{
    public partial class Travel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string EMail { get; set; }
        public int PhoneNumber { get; set; }
        public string TravelLocation { get; set; }
    }
}
