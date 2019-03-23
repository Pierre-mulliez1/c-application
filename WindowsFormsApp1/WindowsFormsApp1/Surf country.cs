using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Surf_country
    {
        private string country;
        private double temperature;
        private decimal price;
      



        public Surf_country (string country, double temperature, decimal price)
        {
           
            this.Temperature = temperature;
            this.Country = country;
            this.Price = price;

        }

       

        public double Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public decimal Price
        {
        
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string getDisplayText(string sep)
        {
            return Country + sep + Temperature + sep + Price;
        }
      



    }
}
