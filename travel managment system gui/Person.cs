using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;




    public abstract class Person
    {
        private string name;
        private int age;
        private string id;
        private string phonenum;
        private string gender;
        private string email;

        public string Name { get => name; set => name = value; }
        public string ID { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => gender; set => gender = value; }
    }

    public class Manager : Person
    {
        Manager(string password, double income)
        {
            this.password = password;
            this.income = income;
        }
        string password;
        double income;
        public Trip CreatTrip()
        {
            throw new NotImplementedException();

        }
        public void DisplayInfo() { }
        public Trip[] ViewHistory()
        {
            throw new NotImplementedException();
        }

    }

   public  class Admin : Person
    {
    Admin(string password)
      {
        this.PassWord = password;
      }
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
   public class TourGuide : Person
    {
    TourGuide(int NoOftripsPerMonth)
    {
        this.NoOftripsPerMonth = NoOftripsPerMonth;
    }
        int NoOftripsPerMonth;
        double SalaryCurrentMonth { get; set; }
        string status { get; set; }
        Trip nexttrip { get; set; }
        Trip[] History { get; set; }
        int NoOfAllTrips { get; set; }
        string SpeakingLanguage;

        public int NoAvailableTourGuide { get; set; }
        public TourGuide(string Id, string Name, string Nationality, int NoOftripsPerMonth, string SpeakingLanguage, string Gender, string Email, string PhoneNumber , double Salary)
        {

            this.ID = Id;
            this.Name = Name;
            this.SpeakingLanguage = SpeakingLanguage;
            this.Gender = Gender;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.SalaryCurrentMonth = Salary;
            this.NoOftripsPerMonth = NoOftripsPerMonth ;
        }


        public double CalcilateSalary()
        {
            throw new NotImplementedException();
            //set el salary bl nesba ll id of tourguide database counter 
        }
        public void DisplayInfo()
        { //dataBase
            throw new NotImplementedException();
        }
        public Trip[] ViewHistory() {
            //dataBase
            throw new NotImplementedException();
        }
    }
   public class Customer : Person
    {
        int NoOfTrips;
        Trip[] History;
        Trip[] NextTrip;
        int NoOfNextTrip;
        bool HaveDisCount;
        public Customer(string name, string phoneNumber, int age,string email ,string Gender )
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Age = age;
            this.Email = email;
            this.Gender = Gender;
            this.NoOfTrips = 0;
            this.HaveDisCount = false;
        }
        public void DisplayInfo() { }
        public void CalculateDiscount() {
            if (NoOfTrips >= 2)
            {
                HaveDisCount = true;
            }
        }
        public void IncNoOfTrips() {
            NoOfTrips++;
        }
        public Trip[] ViewHistory() { throw new NotImplementedException(); }
        public void CheckHistory() { }
        public void AddTrip(Trip T) { }
        public Trip[] ViewNextTrips() { throw new NotImplementedException(); }
    }
