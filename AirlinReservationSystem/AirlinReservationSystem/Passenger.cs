using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinReservationSystem
{
    public class Passenger : Person
    {
        public string DOB { get; set; }
        public string PassNumber { get; set; }
        public string flightName { get; set; }

        public Passenger(string firstName, string lastName, string dob, string passnumber, string flightNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DOB = dob;
            this.PassNumber = passnumber;
            this.flightName = flightNumber;
        }
    }
}
