using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Airpot_V2
{
    abstract class Menu
    {
        public static void Start()
        {
            string enter;
            Console.SetWindowSize(120, 40);
            Flight[] flightarray = null;
            bool work = true, parsing;
            flightarray = UnitManager.Start();
            int choose;
            do
            {
                Console.Clear();
                Console.WriteLine(@"Enter number of action:
1. Print flights
2. Print passangers
3. Add flight
4. Add passanger (by flight number)
5. Delete flight
6. Delete passanger (by flight number)
7. Edit flight
8. Edit passanger (by flight number)
9. Search passengers
10. Search flight bt price of economy ticket
11. Stop work");
                parsing = int.TryParse(Console.ReadLine(), out choose);
                switch (choose)
                {
                    case 1:
                        Printer.FlightPrint(flightarray);
                        Console.WriteLine("Press Any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        bool b = false;
                        Printer.FlightPrint(flightarray);
                        Console.WriteLine("Select race by number");
                        parsing = int.TryParse(Console.ReadLine(), out choose);
                        if (parsing)
                        {
                            for (int i = 0; i < flightarray.Length; i++)
                            {
                                if (flightarray[i] != null)
                                {
                                    if (flightarray[i].FlightNumber == choose)
                                    {
                                        Printer.PassangerPrint(flightarray[i].passangers);
                                        b = true;
                                    }
                                }
                            }
                        }
                        if (!b)
                        {
                            Console.WriteLine("There is not flight with this number");
                        }
                        Console.WriteLine("Press Any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Flight flight;
                        do
                        {
                            flight = UnitManager.CreateFlight();
                        }
                        while (flight == null);
                        UnitManager.AddFlight(flightarray, flight);
                        Printer.FlightPrint(flightarray);
                        Console.WriteLine("Press Any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        Passenger passanger;
                        Printer.FlightPrint(flightarray);
                        Console.WriteLine("Select race by number");
                        parsing = int.TryParse(Console.ReadLine(), out choose);
                        if (parsing)
                        {
                            for (int i = 0; i < flightarray.Length; i++)
                            {
                                if (flightarray[i] != null)
                                {
                                    if (flightarray[i].FlightNumber == choose)
                                    {
                                        do
                                        {
                                            passanger = UnitManager.CreatePassanger();
                                        }
                                        while (passanger == null);
                                        UnitManager.AddPassanger(flightarray[i].passangers, passanger);
                                        Console.WriteLine("Press Any key to continue");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("There is not this flight");
                                        break;
                                    }
                                }
                            }
                        }

                        break;
                    case 5:
                        Printer.FlightPrint(flightarray);
                        UnitManager.DeleteFlight(flightarray);
                        Console.WriteLine("Press Any key to continue");
                        Console.ReadKey();
                        break;
                    case 6:
                        Printer.FlightPrint(flightarray);
                        Console.WriteLine("Select race by number");
                        parsing = int.TryParse(Console.ReadLine(), out choose);
                        if (parsing)
                        {
                            for (int i = 0; i < flightarray.Length; i++)
                            {
                                if (flightarray[i] != null && flightarray[i].FlightNumber == choose)
                                {

                                    Printer.PassangerPrint(flightarray[i].passangers);
                                    flightarray[i].passangers = UnitManager.DeletePassanger(flightarray[i].passangers);
                                    Console.WriteLine("Press Any key to continue");
                                    Console.ReadKey();
                                }
                            }
                        }
                        break;
                    case 7:
                        Printer.FlightPrint(flightarray);
                        Console.WriteLine("Select race by number");
                        parsing = int.TryParse(Console.ReadLine(), out choose);
                        if (parsing)
                        {
                            for (int i = 0; i < flightarray.Length; i++)
                            {
                                if (flightarray[i] != null && flightarray[i].FlightNumber == choose)
                                {
                                    UnitManager.EditFlight(flightarray, i);


                                }
                            }
                        }
                        break;
                    case 8:

                        Printer.FlightPrint(flightarray);
                        Console.WriteLine("Select race by number");
                        parsing = int.TryParse(Console.ReadLine(), out choose);
                        if (parsing)
                        {
                            for (int i = 0; i < flightarray.Length; i++)
                            {
                                if (flightarray[i] != null && flightarray[i].FlightNumber == choose)
                                {
                                    Printer.PassangerPrint(flightarray[i].passangers);
                                    Console.WriteLine("Enter passport number of passanger");
                                    enter = Console.ReadLine();

                                    for (int j = 0; j < flightarray[i].passangers.Length; j++)
                                    {
                                        if (flightarray[i].passangers[j] != null && flightarray[i].passangers[j].Passport == enter)
                                        {
                                            UnitManager.EditPassanger(flightarray[i].passangers[j]);
                                        }
                                        
                                    }

                                        

                                    
                                }
                            }
                        }
                        break;
                    case 9:
                        Console.WriteLine(@"Select search method
1. By firstname
2. By lastname
3. By flightnumber
4. By passport");
                        parsing = int.TryParse(Console.ReadLine(), out choose);
                        if (parsing)
                        {
                            switch (choose)
                            {
                                case 1:
                                    Console.WriteLine("Enter firstname");
                                    string enteredString = Console.ReadLine();
                                    for (int i = 0; i < flightarray.Length; i++)
                                    {
                                        if (flightarray[i] != null)
                                        {
                                            for (int j = 0; j < flightarray[i].passangers.Length; j++)
                                            {
                                                if (flightarray[i].passangers[j] != null && flightarray[i].passangers[j].FirstName.ToUpper().Contains(enteredString.ToUpper()))
                                                {
                                                    Console.WriteLine(flightarray[i].passangers[j]);
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("Press Any key to continue");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter lastname");
                                    enteredString = Console.ReadLine();
                                    for (int i = 0; i < flightarray.Length; i++)
                                    {
                                        if (flightarray[i] != null)
                                        {
                                            for (int j = 0; j < flightarray[i].passangers.Length; j++)
                                            {
                                                if (flightarray[i].passangers[j] != null && flightarray[i].passangers[j].LastName.ToUpper().Contains(enteredString.ToUpper()))
                                                {
                                                    Console.WriteLine(flightarray[i].passangers[j]);
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("Press Any key to continue");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    b = false;
                                    Printer.FlightPrint(flightarray);
                                    Console.WriteLine("Select race by number");
                                    parsing = int.TryParse(Console.ReadLine(), out choose);
                                    if (parsing)
                                    {
                                        for (int i = 0; i < flightarray.Length; i++)
                                        {
                                            if (flightarray[i] != null)
                                            {
                                                if (flightarray[i].FlightNumber == choose)
                                                {
                                                    Printer.PassangerPrint(flightarray[i].passangers);
                                                    b = true;

                                                }
                                            }
                                        }
                                    }
                                    if (!b)
                                    {
                                        Console.WriteLine("There is not flight with this number");
                                    }
                                    Console.WriteLine("Press Any key to continue");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter passport number");
                                    enteredString = Console.ReadLine();
                                    for (int i = 0; i < flightarray.Length; i++)
                                    {
                                        if (flightarray[i] != null)
                                        {
                                            for (int j = 0; j < flightarray[i].passangers.Length; j++)
                                            {
                                                if (flightarray[i].passangers[j] != null && flightarray[i].passangers[j].Passport.ToUpper().Contains(enteredString.ToUpper()))
                                                {
                                                    Console.WriteLine(flightarray[i].passangers[j]);
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("Press Any key to continue");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Wrong search method");
                                    break;
                            }
                        }

                        break;
                    case 10:
                        SearchManager.SearchFlightByPrice(flightarray);
                        Console.WriteLine("Press Any key to continue");
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.WriteLine("Work stopped!");
                        work = false;
                        break;
                    default:
                        Console.WriteLine("You entered wrong action");
                        Thread.Sleep(1500);
                        break;

                }
            } while (work);
        }
    }
}
