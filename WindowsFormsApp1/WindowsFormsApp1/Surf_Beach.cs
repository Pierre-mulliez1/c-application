using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class surf_beach : Surf_country
    {
        public string beach;
        //subclass for th ebeaches of each country
        public surf_beach(string beach, decimal price, double temperature, string Beach) : base(country, temperature, price)
        {
            this.Beach = beach;
        }

        public string Beach
        {
            get
            {
                return beach;

            }
            set
            {
                beach = value;
            }
        }
    }
}