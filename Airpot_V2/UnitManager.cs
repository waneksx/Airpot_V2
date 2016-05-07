using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airpot_V2
{
    abstract class UnitManager
    {
        public static Flight[] Start()
        {
            Flight[] FlightArray = new Flight[10];
            #region StartInitialization
            FlightArray[0] = new Flight() { Airline = "MAU", City = "Kiev", Date = new DateTime(2016, 3, 24, 12, 45, 00), FlightNumber = 114, Gate = 1, State = Direction.Arrival, Status = Status.arrived, Terminal = 2 };

            FlightArray[0].passangers[0] = new Passenger("Peter", "Sanders", "Ukrainian", "2114156", new DateTime(1996, 8, 6), Passenger.sex.Male, 300.00, Ticket.TicketClass.Economy);
            FlightArray[0].passangers[1] = new Passenger("Mike", "Zubrovski", "Polish", "WN235177", new DateTime(1987, 12, 31), Passenger.sex.Male, 269.99, Ticket.TicketClass.Business);
            FlightArray[0].passangers[2] = new Passenger("Elzbeth", "Zubrovski", "Ukrainian", "FG390089", new DateTime(1995, 1, 7), Passenger.sex.Female, 279.99, Ticket.TicketClass.Business);
            FlightArray[0].passangers[3] = new Passenger("Antony", "Zubrovski", "Polish", "ZL214512", new DateTime(1996, 8, 6), Passenger.sex.Male, 149.99, Ticket.TicketClass.Economy);
            FlightArray[0].passangers[4] = new Passenger("Jeremiah", "Gray", "English", "KM5XWL3", new DateTime(1985, 6, 21), Passenger.sex.Male, 329.99, Ticket.TicketClass.Business);



            FlightArray[1] = new Flight() { Airline = "Qatar", City = "Moskow", Date = new DateTime(2016, 4, 12, 02, 20, 00), FlightNumber = 216, Gate = 2, State = Direction.Departure, Status = Status.checkIn, Terminal = 3 };

            FlightArray[1].passangers[0] = new Passenger("John", "Brown", "English", "HKO4MWJ", new DateTime(1985, 11, 15), Passenger.sex.Male, 129.99, Ticket.TicketClass.Economy);
            FlightArray[1].passangers[1] = new Passenger("Ivan", "Sakharchuk", "Austrian", "HKO4MWJ", new DateTime(1971, 2, 3), Passenger.sex.Male, 99.99, Ticket.TicketClass.Economy);
            FlightArray[1].passangers[2] = new Passenger("Roberto", "Tomason", "Brazilian", "JA5VTZT", new DateTime(1961, 6, 5), Passenger.sex.Male, 199.99, Ticket.TicketClass.Economy);
            FlightArray[1].passangers[3] = new Passenger("Mario", "Carleone", "Italian", "PX3ZF8U", new DateTime(1976, 8, 22), Passenger.sex.Male, 169.99, Ticket.TicketClass.Economy);


            FlightArray[2] = new Flight() { Airline = "UralAir", City = "Penza", Date = new DateTime(2016, 3, 14, 19, 3, 00), FlightNumber = 185, Gate = 3, State = Direction.Arrival, Status = Status.arrived, Terminal = 2 };

            FlightArray[2].passangers[0] = new Passenger("Peter", "Wilson", "English", "RZ06V8S", new DateTime(1976, 12, 15), Passenger.sex.Male, 349.99, Ticket.TicketClass.Economy);
            FlightArray[2].passangers[1] = new Passenger("Ivan", "Bailey", "Ukrainian", "UOTRSRG", new DateTime(1956, 10, 9), Passenger.sex.Male, 359.99, Ticket.TicketClass.Business);
            FlightArray[2].passangers[2] = new Passenger("Amber", "Cooper", "English", "3LLUHS1", new DateTime(1979, 4, 4), Passenger.sex.Female, 339.99, Ticket.TicketClass.Economy);


            FlightArray[3] = new Flight() { Airline = "Spirit", City = "London", Date = new DateTime(2016, 3, 28, 2, 15, 00), FlightNumber = 115, Gate = 2, State = Direction.Departure, Status = Status.canceled, Terminal = 3 };

            FlightArray[3].passangers[0] = new Passenger("Peter", "Wilson", "English", "HKO4MWJ", new DateTime(1976, 12, 15), Passenger.sex.Male, 949.99, Ticket.TicketClass.Economy);
            FlightArray[3].passangers[1] = new Passenger("Allison", "Bailey", "English", "ZMD6XSD", new DateTime(1956, 10, 9), Passenger.sex.Female, 959.99, Ticket.TicketClass.Business);
            FlightArray[3].passangers[2] = new Passenger("Madeline", "Cooper", "English", "E9W9VI1", new DateTime(1979, 4, 4), Passenger.sex.Female, 939.99, Ticket.TicketClass.Economy);
            FlightArray[3].passangers[3] = new Passenger("Victoria", "Gray", "English", "ID40F6Z", new DateTime(1985, 6, 21), Passenger.sex.Male, 929.99, Ticket.TicketClass.Business);


            FlightArray[4] = new Flight() { Airline = "SAS", City = "Chicago", Date = new DateTime(2016, 2, 24, 14, 00, 00), FlightNumber = 642, Gate = 1, State = Direction.Arrival, Status = Status.expectedAt, Terminal = 2 };

            FlightArray[4].passangers[0] = new Passenger("Peter", "Cox", "English", "C5EWPZU", new DateTime(1976, 12, 15), Passenger.sex.Male, 609.99, Ticket.TicketClass.Economy);
            FlightArray[4].passangers[1] = new Passenger("Sarah", "Ramirez", "English", "XC7QRZ2", new DateTime(1956, 10, 9), Passenger.sex.Female, 529.99, Ticket.TicketClass.Business);
            


            FlightArray[5] = new Flight() { Airline = "KLM", City = "New York", Date = new DateTime(2016, 4, 7, 23, 36, 00), FlightNumber = 434, Gate = 3, State = Direction.Arrival, Status = Status.unknown, Terminal = 1 };

            FlightArray[5].passangers[0] = new Passenger("Joshua", "Price", "English", "UUX459H", new DateTime(1976, 12, 15), Passenger.sex.Male, 779.99, Ticket.TicketClass.Business);
            



            return FlightArray;

            #endregion
        }

        public static Flight[] AddFlight(Flight[] flightarray, Flight flight)
        {
            for (int i = 0; i < flightarray.Length; i++)
            {
                if (flightarray[i] == null)
                {
                    flightarray[i] = flight;
                    return flightarray;
                }

            }
            Console.WriteLine("Array overflow");
            return flightarray;
        }
        public static Flight CreateFlight()
        {


            Console.WriteLine(@"Enter creation mode: 
1. <S>imple 
2. <F>ull");
            string mode = Console.ReadLine().ToUpper();
            if (mode == "S")
            {
                Flight flight = new Flight();
                Console.WriteLine("Simple flight with number {0} was created", flight.FlightNumber);
                return flight;
            }
            else if (mode == "F")
            {
                bool isParsed;
                Console.WriteLine("Enter new flight number");
                int flightNumber;
                isParsed = int.TryParse(Console.ReadLine(), out flightNumber);
                if (!isParsed) return null;
                Console.WriteLine("Enter new city");
                string city = Console.ReadLine();
                Console.WriteLine("Enter new airline");
                string airline = Console.ReadLine();
                Console.WriteLine("Enter new terminal");
                int terminal;
                isParsed = int.TryParse(Console.ReadLine(), out terminal);
                if (!isParsed) return null;
                Console.WriteLine("Enter gate number");
                int gate;
                isParsed = int.TryParse(Console.ReadLine(), out gate);
                if (!isParsed) return null;
                Console.WriteLine("Enter new date (year, month, day, hour, minute)");
                Console.WriteLine("Year: ");
                int year;
                isParsed = int.TryParse(Console.ReadLine(), out year);
                if (!isParsed) return null;
                Console.WriteLine("Month: ");
                int month;
                isParsed = int.TryParse(Console.ReadLine(), out month);
                if (!isParsed) return null;
                Console.WriteLine("Day: ");
                int day;
                isParsed = int.TryParse(Console.ReadLine(), out day);
                if (!isParsed) return null;
                Console.WriteLine("Hour: ");
                int hour;
                isParsed = int.TryParse(Console.ReadLine(), out hour);
                if (!isParsed) return null;
                Console.WriteLine("Minute: ");
                int minute;
                isParsed = int.TryParse(Console.ReadLine(), out minute);
                if (!isParsed) return null;
                Console.WriteLine(@"Enter new status:
check-in = 1 , 
gate closed = 2, 
arrived = 3, 
departed at = 4 ,
unknown = 5, 
canceled = 6,
expected at = 7, 
delayed = 8, 
in flight = 9");
                int select;
                isParsed = int.TryParse(Console.ReadLine(), out select);
                if (!isParsed || select < 1 || select > 9) return null;
                Status status = (Status)select;
                Console.WriteLine(@"Select direction:
Arrival = 1
Departure = 2");
                isParsed = int.TryParse(Console.ReadLine(), out select);
                if (!isParsed || select < 1 || select > 2) return null;
                Direction direction = (Direction)select;
                return new Flight(year, month, day, hour, minute, flightNumber, gate, terminal, city, airline, status, direction);
            }
            else
            {
                Console.WriteLine("You entered wrong letter. Choose <S> or <F>");
                return null;
            }


        }

        public static void EditFlight(Flight[] flightarray, int count)
        {
            Console.WriteLine(@"Enter parametr to change:
1. Flight number(it will unique number)
2. Date
3. Gate
4. Terminal
5. City
6. Airline
7. Status
8. State");
            int choose;
            bool parse = false, unique = true;
            parse = int.TryParse(Console.ReadLine(), out choose);
            if (parse)
            {
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter new flight number");
                        parse = int.TryParse(Console.ReadLine(), out choose);
                        if (parse)
                        {


                            for (int i = 0; i < flightarray.Length; i++)
                            {
                                if (flightarray[i] != null && flightarray[i].FlightNumber == choose)
                                {
                                    unique = false;
                                }
                            }
                            if (unique)
                            {
                                flightarray[count].FlightNumber = choose;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter new date (year, month, day, hour, minute)");
                        Console.WriteLine("Year: ");
                        int year;
                        parse = int.TryParse(Console.ReadLine(), out year);
                        Console.WriteLine("Month: ");
                        int month;
                        parse = int.TryParse(Console.ReadLine(), out month);
                        Console.WriteLine("Day: ");
                        int day;
                        parse = int.TryParse(Console.ReadLine(), out day);
                        Console.WriteLine("Hour: ");
                        int hour;
                        parse = int.TryParse(Console.ReadLine(), out hour);
                        Console.WriteLine("Minute: ");
                        int minute;
                        parse = int.TryParse(Console.ReadLine(), out minute);
                        flightarray[count].Date = new DateTime(year, month, day, hour, minute, 0);
                        break;
                    case 3:
                        Console.WriteLine("Enter new gate");
                        parse = int.TryParse(Console.ReadLine(), out choose);
                        if (parse)
                        {
                            flightarray[count].Gate = choose;
                        }

                        break;
                    case 4:
                        Console.WriteLine("Enter new terminal number");
                        parse = int.TryParse(Console.ReadLine(), out choose);
                        if (parse)
                        {
                            flightarray[count].Terminal = choose;
                        }

                        break;
                    case 5:
                        Console.WriteLine("Enter new city");
                        string city;
                        city = Console.ReadLine();

                        flightarray[count].City = city;


                        break;
                    case 6:
                        Console.WriteLine("Enter new airline");
                        string airline;
                        airline = Console.ReadLine();

                        flightarray[count].Airline = airline;
                        break;

                    case 7:
                        Console.WriteLine(@"Enter new status:
check-in = 1 , 
gate closed = 2, 
arrived = 3, 
departed at = 4 ,
unknown = 5, 
canceled = 6,
expected at = 7, 
delayed = 8, 
in flight = 9");

                        parse = int.TryParse(Console.ReadLine(), out choose);
                        if (parse && choose > 0 && choose < 10)
                            flightarray[count].Status = (Status)choose;
                        break;


                    case 8:
                        Console.WriteLine(@"Select new direction:
Arrival = 1
Departure = 2");
                        parse = int.TryParse(Console.ReadLine(), out choose);
                        if (parse && choose > 0 && choose < 3)
                            flightarray[count].State = (Direction)choose;
                        break;

                    default:
                        Console.WriteLine("You entered wrong number!");
                        break;
                }
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();

        }

        public static Passenger[] AddPassanger(Passenger[] passangers, Passenger passanger)
        {
            for (int i = 0; i < passangers.Length; i++)
            {
                if (passangers[i] == null)
                {
                    passangers[i] = passanger;
                    return passangers;
                }

            }
            Console.WriteLine("Array overflow");
            return passangers;
        }
        public static Passenger CreatePassanger()
        {
            Console.WriteLine(@"Enter creation mode: 
1. <S>imple 
2. <F>ull");
            string mode = Console.ReadLine().ToUpper();
            if (mode == "S")
            {
                Passenger passanger = new Passenger();
                Console.WriteLine("Simple passanger with name {0} was created", passanger.FirstName);
                return passanger;

            }
            else if (mode == "F")
            {
                bool isParsed;
                Console.WriteLine("Enter first name");
                string firstname = Console.ReadLine();
                Console.WriteLine("Enter last name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter nationality");
                string nationality = Console.ReadLine();
                Console.WriteLine("Enter passport number");
                string passport = Console.ReadLine();
                Console.WriteLine("Enter birthday (year, month, day)");
                Console.WriteLine("Year: ");
                int year;
                isParsed = int.TryParse(Console.ReadLine(), out year);
                if (!isParsed) return null;
                Console.WriteLine("Month: ");
                int month;
                isParsed = int.TryParse(Console.ReadLine(), out month);
                if (!isParsed) return null;
                Console.WriteLine("Day: ");
                int day;
                isParsed = int.TryParse(Console.ReadLine(), out day);
                if (!isParsed) return null;
                Console.WriteLine(@"Select sex:
Male = 1
Female = 2");
                int select;
                isParsed = int.TryParse(Console.ReadLine(), out select);
                if (!isParsed || select < 1 || select > 9) return null;
                Passenger.sex sex = (Passenger.sex)select;
                Console.WriteLine("Enter ticket price ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine(@"Select ticket class:
Economy = 1
Busyness = 2");
                isParsed = int.TryParse(Console.ReadLine(), out select);
                if (!isParsed || select < 1 || select > 2) return null;
                Ticket.TicketClass ticketClass = (Ticket.TicketClass)select;
                Console.WriteLine("Passanger with name {0} was created", firstname);
                return new Passenger(firstname, lastName, nationality, passport, new DateTime(year, month, day), sex, price, ticketClass);
            }
            else
            {
                Console.WriteLine("You entered wrong letter. Choose <S> or <F>");
                return null;
            }
        }
        public static Flight[] DeleteFlight(Flight[] flightarray)
        {
            bool isParsed;
            int choose;
            Console.WriteLine("Enter flight number");
            isParsed = int.TryParse(Console.ReadLine(), out choose);
            if (!isParsed) return flightarray;

            do
            {


                for (int i = 0; i < flightarray.Length; i++)
                {
                    if (flightarray[i] != null && flightarray[i].FlightNumber == choose)
                    {
                        flightarray[i] = null;
                    }
                }
            } while (isParsed == false);
            return flightarray;
        }
        public static Passenger[] DeletePassanger(Passenger[] passangerArray)
        {
            string pass;
            bool success = false;
            Console.WriteLine("Enter passport number ");
            pass = Console.ReadLine().ToUpper();
            for (int i = 0; i < passangerArray.Length && !success; i++)
            {
                if (passangerArray[i] != null && passangerArray[i].Passport.ToUpper() == pass)
                {
                    passangerArray[i] = null;
                    success = true;
                    Console.WriteLine($"Passanger {passangerArray[i].FirstName} {passangerArray[i].LastName} was deleted");
                }

            }
            if (!success)
                Console.WriteLine("There is not passanger with this passport number");

            return passangerArray;

        }
        public static void EditPassanger(Passenger passanger)
        {
            Console.WriteLine(@"Enter parametr to change:
1. Firstname
2. Lastname
3. Passport
4. Birthday
5. Nationality
6. Sex");
            int choose;
            string enter;
            bool parse = false;
            parse = int.TryParse(Console.ReadLine(), out choose);
            if (parse)
            {
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter new firstname");
                        enter = Console.ReadLine();
                        passanger.FirstName = enter;
                        break;
                    case 2:
                        Console.WriteLine("Enter new lastname");
                        enter = Console.ReadLine();
                        passanger.LastName = enter;
                        break;
                    case 3:
                        Console.WriteLine("Enter new passport number");
                        enter = Console.ReadLine();
                        passanger.Passport = enter;
                        break;
                    case 4:
                        Console.WriteLine("Enter new birthday (year, month, day)");
                        Console.WriteLine("Year: ");
                        int year;
                        parse = int.TryParse(Console.ReadLine(), out year);
                        Console.WriteLine("Month: ");
                        int month;
                        parse = int.TryParse(Console.ReadLine(), out month);
                        Console.WriteLine("Day: ");
                        int day;
                        parse = int.TryParse(Console.ReadLine(), out day);
                        passanger.Birthday = new DateTime(year, month, day);
                        break;
                    case 5:
                        Console.WriteLine("Enter new nationality");
                        enter = Console.ReadLine();
                        passanger.Nationality = enter;
                        break;
                    case 6:
                        Console.WriteLine(@"Enter new sex:
Male = 1 , 
Female = 2");
                        parse = int.TryParse(Console.ReadLine(), out choose);
                        if (parse && choose > 0 && choose < 3)
                            passanger.Sex = (Passenger.sex)choose;
                        break;                   
                    default:
                        Console.WriteLine("You entered wrong parametr");
                        break;


                }
            }
        }
    }
}
