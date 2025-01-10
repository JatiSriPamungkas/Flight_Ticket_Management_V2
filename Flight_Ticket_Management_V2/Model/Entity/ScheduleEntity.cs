using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_Management_V2.Model.Entity
{
    public class ScheduleEntity
    {
        public string Airline { get; set; }
        public string AircraftType { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public int Price { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
    }
}
