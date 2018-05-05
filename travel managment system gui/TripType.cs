using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Travel_Managment_System;

public class Family : Trip
{
    int NoFamilyMembers;
    internal List<Customer>FamilyMemeber;
   public Family(int NoFamilyMembers)
    {
        this.NoFamilyMembers = NoFamilyMembers;
        FamilyMemeber = new List<Customer>();
    }

}
public class Couple : Trip
{
    int NoOfCouples;
    internal List<Customer> couple;
    public Couple(int NoOfCouples)
    {
        this.NoOfCouples = NoOfCouples;
        couple = new List<Customer>();
    }
}
public class General : Trip
{
    int NoOfTourists;
    internal List<Customer> tourists;
  public General(int NoOfTourists)
    {
        this.NoOfTourists = NoOfTourists;
        tourists = new List<Customer>();
    }
}