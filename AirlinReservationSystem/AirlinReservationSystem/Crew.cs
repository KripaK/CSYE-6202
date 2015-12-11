using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinReservationSystem
{
    public class Crew : Person
    {
       public string FlightName { get; set; }
        
        public Crew(string firstName, string lastName, string flightName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FlightName = flightName;
        }
    }
}
