using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airpot_V2
{
    abstract class SearchManager
    {
        public static void SearchFlightByPrice(Flight[] flightarray)
        {
            bool isParsed;
            double choose;
            Console.WriteLine("Enter price");
            isParsed = double.TryParse(Console.ReadLine(), out choose);            
            
            for (int i = 0; i < flightarray.Length; i++)
            {
                bool founded = false;
                if (flightarray[i] != null)
                { 
                for (int j = 0; j < flightarray[i].passangers.Length && !founded; j++)
                {
                        if (flightarray[i].passangers[j] != null && flightarray[i].passangers[j].Ticket.price < choose)

                        {
                            Console.WriteLine(flightarray[i]);
                            founded = true;
                        }
                }
                }
            }
           
        }

    }
}
