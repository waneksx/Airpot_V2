using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airpot_V2
{
    
    public struct Ticket
    {
        public enum TicketClass
        {
            Business = 1, Economy
        }

        public TicketClass ticketClass;
        public double price;
        public Ticket(double price, TicketClass ticketClass)
        {
            this.ticketClass = ticketClass;
            if (ticketClass == TicketClass.Business)
                this.price = price*1.5;
            else this.price = price;
        }
    }



    class Passenger
    {
        public enum sex
        {
            Male =1 , Female
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string Passport { get; set; }
        public DateTime Birthday { get; set; }
        public sex Sex { get; set; }
        public Ticket Ticket { get; set; }

        public Passenger (string firstName, string lastName, string nationality, string passport, DateTime birthday, sex sex, double price, Ticket.TicketClass ticketClass)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
            Passport = passport;
            Birthday = birthday;
            Sex = sex;
            Ticket = new Ticket(price, ticketClass);
        }

        public Passenger()
        {
            FirstName = "John";
            LastName = "Brown";
            Nationality = "English";
            Passport = "GB158906";
            Birthday = new DateTime(1986, 10, 12);
            Sex = sex.Male;
            Ticket = new Ticket(300, Ticket.TicketClass.Economy);

        }

        public override string ToString()
        {
            string passangersString = String.Format(" {0,-10} {1,-10} {2,-6} {3,-12} {4,-8} {5, -7} {6, -8} {7, -6}$", FirstName, LastName, Sex, Nationality, Passport, Birthday.ToString("dd.MM.yyyy"), Ticket.ticketClass, Ticket.price.ToString("#.##"));
            return passangersString;
        }






    }
}
