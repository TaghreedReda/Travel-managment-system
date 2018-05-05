using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace Travel_Managment_System
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

    class Manager : person
    {
        string password;
        double income;
        public Trip CreatTrip() {
            throw new NotImplementedException();
        }
        public void DisplayInfo() { }
        public Trip[] ViewHistory() {
            throw new NotImplementedException();
        }

    }
    class Admin : person
    {
        string PassWord;
        public Customer[] EditCustomerAcc() { throw new NotImplementedException(); }
        public void AddCustomer(Customer customer) { }
        public void DisplayCustomer(DataTable dt)
        {
            
            SqlConnection connection;
            SqlCommand command;

            string sql = "Select Customer_ID , First_Name , NoOfTrips from Customer";
            SqlDataReader dataReader;
            string connetionString = @"Data Source=DESKTOP-JBGTNMS\MSSQLSERVER01;Initial Catalog=TravelManagmentSystem;Integrated Security=SSPI";
            connection = new SqlConnection(connetionString);
            // Display The DataBase
            string []Name = new string[1000];
            connection.Open();

            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                dt.Columns.Add((string)dataReader.GetValue(0) , typeof(int));
                dt.Columns.Add((string)dataReader.GetValue(1), typeof(string));
                dt.Columns.Add((string)dataReader.GetValue(2), typeof(int));
    
            }
            dataReader.Close();
            command.Dispose();
            connection.Close();



        }
        public void DeleteCustomer(string ID) { }
        public void AddTourGuide(TourGuide tour_guide) { }
        public TourGuide[] EditTourGuideAcc() { throw new NotImplementedException(); }
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
        Trip[] History { get; set; }
        int NoOfAllTrips { get; set; }
        public int NoAvailableTourGuide { get; set; }
        public double CalcilateSalary()
        {
            throw new NotImplementedException();
            //set el salary bl nesba ll id of tourguide database counter 
        }
        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
        public Trip[] ViewHistory() {
            throw new NotImplementedException();
        }
    }
    class Customer : person
    {
        int NoOfTrips;
        Trip[] History;
        Trip[] NextTrip;
        int NoOfNextTrip;
        public void DisplayInfo() { }
        public void CalculateDiscount() { }
        public void IncNoOfTrips() { }
        public Trip[] ViewHistory() { throw new NotImplementedException(); }
        public void CheckHistory() { }
        public void AddTrip(Trip T) { }
        public Trip[] ViewNextTrips() { throw new NotImplementedException(); }
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
    class Family : Trip
    {
        int NoFamilyMembers;
        Customer[] FamilyMemeber;
    }
    class Couple : Trip
    {
        int NoOfCouples;
        Customer[] couple;
    }
    class General : Trip
    {
        int NoOfTourists;
        Customer[] Tourists;
    }

}
