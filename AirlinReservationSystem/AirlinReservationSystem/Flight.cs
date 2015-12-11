using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinReservationSystem
{
    public class Flight
    {
        public string FlightName { get; set; }
        public string Date { get; set; }
        public string Destination { get; set; }
        public string Arrival { get; set; }
        public string CarrierName { get; set; }
        public string Class { get; set; }

        public Flight(string flightName, string date, string dest, string arrival, string carrier, string classnamw)
        {
            this.FlightName = flightName;
            this.Date = date;
            this.Destination = dest;
            this.Arrival = arrival;
            this.CarrierName = carrier;
            this.Class = classnamw;
        }


    }
}
