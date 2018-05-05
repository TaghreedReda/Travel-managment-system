using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Travel_Managment_System;

namespace travel_managment_system_gui
{
    public class Ticket
    {
       private City From;
        private City To;
        private string seatnum;
        private DateTime Date;
        private TimeSpan Duration;
        private TimeSpan ArrivalTime;
        private TimeSpan DepartureTime;
        private string TicketNo;
        private Customer customer;
        private string level;
        private double Price;

        public Ticket(City from , City to,string seatnum,DateTime date,TimeSpan duration,TimeSpan arrivaltime,TimeSpan departuretime, string ticketnumber,Customer customer,string level,double price)
        {
            this.From = from;
            this.To = to;
            this.seatnum = seatnum;
            this.Date = date;
            this.Duration = duration;
            this.ArrivalTime = arrivaltime;
            this.DepartureTime = departuretime;
            this.TicketNo = ticketnumber;
            this.customer = customer;
            this.level = level;
            this.Price = price;
        }
        public City from { get => From; set => From = value; }
        public City to { get => To; set => To = value; }
        public string Seatnum { get => seatnum; set => seatnum = value; }
        public DateTime date { get => Date; set => Date = value; }
        public TimeSpan duration { get => Duration; set => Duration = value; }
        public TimeSpan arrivalTime { get => ArrivalTime; set => ArrivalTime = value; }
        public TimeSpan departureTime { get => Duration; set => Duration = value; }
        public string ticketNo { get => TicketNo; set => TicketNo = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public string Level { get => level; set => level = value; }
        public double price { get => Price; set => Price = value; }
    }
}