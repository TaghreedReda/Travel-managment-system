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
    public class City
    {
        private float Weather;
        private string Transportation;
        private string Language;
        private TimeSpan EastrenTime;
        internal List<string> Sights;
        private double ForeignCurrency;

        public City(float Weather, string Transportation, string Language, TimeSpan EastrenTime, double ForeignCurrency)
        {
            this.Weather = Weather;
            this.Transportation = Transportation;
            this.Language = Language;
            this.EastrenTime = EastrenTime;
            this.ForeignCurrency = ForeignCurrency;
            Sights = new List<string>();

        }

        public void setSights(string[] obj)
        {
            obj = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Sights.Add(obj[i]);
            }
            return;
        }
        public int SetSights() { return 0; }
        public float weather { get => Weather; set => Weather = value; }
        public string transportation { get => Transportation; set => Transportation = value; }
        public string language { get => Language; set => Language = value; }
        public TimeSpan eastrenTime { get => EastrenTime; set => EastrenTime = value; }
        public double foreignCurrency { get => ForeignCurrency; set => ForeignCurrency = value; }
        internal List<City> sights { get => sights; set => sights = value; }

    }
}