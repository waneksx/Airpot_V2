using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airpot_V2.Units
{
    interface IFlight
    {
        DateTime Date { get; set; }
        int FlightNumber { get; set; }       
        string City { get; set; }
        string Airline { get; set; }
    }
}
