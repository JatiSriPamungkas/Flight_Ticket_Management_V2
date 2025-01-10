using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_Management_V2.Model.Entity
{
    public class Passenger
    {
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string Class { get; set; }
        public string Passengers { get; set; }
    }
}
