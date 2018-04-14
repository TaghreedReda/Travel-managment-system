using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp10
{
    class person
    {
        string name;
        int age;
        string id;
        string phonenum;
        string gender;
        public void Displayinfo()
        {

        }
    }

    class Manager:person
    {
        string password;
        double income;
        public Trip CreatTrip(){ }
        public void DisplayInfo() { }
        public Trip[] ViewHistory() { }

    }
    class Admin:person
    {
        string PassWord;
        public Customer[] EditCustomerAcc() { }
        public void AddCustomer(Customer customer) { }
        public void DeleteCustomer(string ID) { }
        public void AddTourGuide(TourGuide tour_guide) { }
        public TourGuide[] EditTourGuideAcc() { }
        public void DeleteTourGuide(string ID) { }
        public bool DiscountCheck(string ID) { return true; }
        public void DisplayInfo() { }
        public bool TicketAvailability(Ticket ticket) { return true; }
    }
    class TourGuide : person
    {
        int NoOftripsPerMonth;
        double SalaryCurrentMonth { get; set; }
        string status { get; set; }
        Trip nexttrip { get; set; }
        Trip []History { get; set; }
        int NoOfAllTrips { get; set; }
        public int NoAvailableTourGuide { get; set; }
        public double CalcilateSalary()
        {
           //set el salary bl nesba ll id of tourguide database counter 
        }
        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
        public Trip[] ViewHistory() { }
    }
    class Customer:person
    {
        int NoOfTrips;
        Trip[] History;
        Trip[] NextTrip;
        int NoOfNextTrip;
        public void DisplayInfo() { }
        public void CalculateDiscount() { }
        public void IncNoOfTrips() { }
        public Trip[] ViewHistory() { }
        public void CheckHistory() { }
        public void AddTrip(Trip T) { }
        public Trip[] ViewNextTrips() { }
    }
    class Ticket
    {
        City From;
        City To;
        string seatnum;
        DateTime Date;
        TimeSpan Duration;
        TimeSpan ArrivalTime;
        TimeSpan DepartureTime;
        string TicketNo;
        Customer customer;
        string level;
        double Price;
    }
    class Trip
    {
        Ticket TicketDitails;
        TourGuide tourguide;
        int NoOfSeats;
        int NoOfAvailableSeats;
        City From;
        City To;
        DateTime Date;
        TimeSpan Duration;
        TimeSpan ArrivalTime;
        TimeSpan DepartureTime;
    }
    class City
    {
        float Weather;
        string Transportation;
        string Language;
        TimeSpan EastrenTime;
        string[] Sights;
        double ForeignCurrency;
    }
    class Family:Trip
    {
        int NoFamilyMembers;
        Customer[] FamilyMemeber;
    }
    class Couple:Trip
    {
        int NoOfCouples;
        Customer[] couple;
    }
    class General:Trip
    {
        int NoOfTourists;
        Customer[] Tourists;
    }
}
