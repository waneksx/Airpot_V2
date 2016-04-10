using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airpot_V2
{
   abstract class Printer
    {
        public static void FlightPrint (Flight [] flightArray)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------------------------------------------------------ ");
            Console.WriteLine(" №   State   Time             City     Airline   Terminal  Status    Gate Passangers ");
            Console.WriteLine("------------------------------------------------------------------------------------ ");
            Console.ResetColor();
            for (int i = 0; i < flightArray.Length; i++)
            {
                if (flightArray[i]!=null)
                {
                    Console.WriteLine(flightArray[i]);
                }
                
            }
           
        }
        public static void PassangerPrint(Passenger[] passangersArray)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------------------------------------------------------------- ");
            Console.WriteLine(" First name Last name  Sex    Nationality  Passport Birthday   Class    Price ");
            Console.WriteLine("----------------------------------------------------------------------------- ");
            Console.ResetColor();

            for (int i = 0; i < passangersArray.Length; i++)
            {
                if (passangersArray[i]!= null)
                {
                    Console.WriteLine(passangersArray[i]);
                }
            }
        }
    }
}
