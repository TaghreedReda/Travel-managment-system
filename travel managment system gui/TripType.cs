using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
//using Travel_Managment_System;

public class Family : Trip
{
    int NoFamilyMembers;
    internal List<Customer>FamilyMemeber;
   public Family(int NoFamilyMembers, Ticket ticketditails, TourGuide tourguide, int NoOfSeats, int NoOfAvailableSeats, City From, City To, DateTime Date, TimeSpan Duration, TimeSpan ArrivalTime, TimeSpan DepartureTime):base( ticketditails, tourguide, NoOfSeats, NoOfAvailableSeats, From, To,Date, Duration, ArrivalTime,DepartureTime)
    {
        this.NoFamilyMembers = NoFamilyMembers;
        FamilyMemeber = new List<Customer>();
    }

}
public class Couple : Trip
{
    int NoOfCouples;
    internal List<Customer> couple;
    public Couple(int NoOfCouples , Ticket ticketditails, TourGuide tourguide, int NoOfSeats, int NoOfAvailableSeats, City From, City To, DateTime Date, TimeSpan Duration, TimeSpan ArrivalTime, TimeSpan DepartureTime) : base(ticketditails, tourguide, NoOfSeats, NoOfAvailableSeats, From, To, Date, Duration, ArrivalTime, DepartureTime)
    {
        this.NoOfCouples = NoOfCouples;
        couple = new List<Customer>();
    }
}
public class General : Trip
{
    int NoOfTourists;
    internal List<Customer> tourists;
  public General(int NoOfTourists, Ticket ticketditails, TourGuide tourguide, int NoOfSeats, int NoOfAvailableSeats, City From, City To, DateTime Date, TimeSpan Duration, TimeSpan ArrivalTime, TimeSpan DepartureTime) : base(ticketditails, tourguide, NoOfSeats, NoOfAvailableSeats, From, To, Date, Duration, ArrivalTime, DepartureTime)
    {
        this.NoOfTourists = NoOfTourists;
        tourists = new List<Customer>();
    }
}