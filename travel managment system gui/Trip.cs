using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
//using Travel_Managment_System;

  public class Trip
    {
        private Ticket TicketDitails;
        private TourGuide tourguide;
        private int NoOfSeats;
        private int NoOfAvailableSeats;
        private City From;
        private City To;
        private DateTime Date;
        private TimeSpan Duration;
        private TimeSpan ArrivalTime;
        private TimeSpan DepartureTime;

        public Trip(Ticket ticketditails, TourGuide tourguide, int NoOfSeats, int NoOfAvailableSeats, City From, City To, DateTime Date, TimeSpan Duration, TimeSpan ArrivalTime, TimeSpan DepartureTime)
        {
            this.TicketDitails = ticketditails;
            this.tourguide = tourguide;
            this.NoOfSeats = NoOfSeats;
            this.NoOfAvailableSeats = NoOfAvailableSeats;
            this.From = From;
            this.To = To;
            this.Date = Date;
            this.Duration = Duration;
            this.ArrivalTime = ArrivalTime;
            this.DepartureTime = DepartureTime;
        }
        public Ticket ticketDitails { get => TicketDitails; set => TicketDitails = value; }
        public TourGuide Tourguide { get => tourguide; set => tourguide = value; }
        public int noOfSeats { get => NoOfSeats; set => NoOfSeats = value; }
        public int noOfAvailableSeats { get => NoOfAvailableSeats; set => NoOfAvailableSeats = value; }
        public City from { get => From; set => From = value; }
        public City to { get => To; set => To = value; }
        public DateTime date { get => Date; set => Date = value; }
        public TimeSpan duration { get => Duration; set => Duration = value; }
        public TimeSpan arrivalTime { get => ArrivalTime; set => ArrivalTime = value; }
        public TimeSpan departureTime { get => DepartureTime; set => DepartureTime = value; }
    }
