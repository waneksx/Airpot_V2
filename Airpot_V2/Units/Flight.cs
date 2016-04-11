using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airpot_V2
{
    public enum Status
    {
        checkIn = 1, gateClosed, arrived, departedAt, unknown, canceled, expectedAt, delayed, inFlight
    }

    public enum Direction
    {
        Arrival = 1, Departure
    }
    class Flight : Units.IFlight
    {
        Random random = new Random();
        public DateTime Date { get; set; }
        public int FlightNumber { get; set; }
        public int Gate { get; set; }
        public int Terminal { get; set; }
        public string City { get; set; }
        public string Airline { get; set; }
        public Status Status { get; set; }
        public Direction State { get; set; }
        public Passenger[] passangers = new Passenger[5];


        public Flight()
        {
            Date = DateTime.Now;
            FlightNumber = random.Next(100, 999);
            Gate = random.Next(1, 4);
            Terminal = random.Next(1, 4);
            City = "Kharkiv";
            Airline = "MAU";
            Status = Status.inFlight;
            State = Direction.Arrival;
        }

        public Flight(int year, int month, int day, int hour, int minute, int flightNumber, int gate, int terminal, string city, string airline, Status status, Direction direction)
        {
            Date = new DateTime(year, month, day, hour, minute, 0);
            FlightNumber = flightNumber;
            Gate = gate;
            Terminal = terminal;
            City = city;
            Airline = airline;
            Status = status;
            State = direction;
        }



        public override string ToString()
        {

            string s = String.Format("{0,-4} {1,-6} {2,-16} {3,-8} {4,-9} {5, -9} {6, -10} {7, -3} {8, -2}", FlightNumber, State, Date.ToString("dd.MM.yyyy HH:mm"), City, Airline, Terminal, Status, Gate, Flight.GetPassangersQuantity(passangers));
            return s;
        }
        public static int GetPassangersQuantity(Passenger[] passangers)
        {
            int quantity = 0;
            for (int i = 0; i < passangers.Length; i++)
            {
                if (passangers[i] != null)
                {
                    quantity++;
                }
            }
            return quantity;
        }
    }
}
