using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSpecsApplication
{
    class Vehicle 
    {
        public string maker;
        public string year;
        public string price;     
        public Vehicle()
        {
        }
        public Vehicle(string a, string b , string c)
        {
            this.maker = a;
            this.year = b;
            this.price = c;
        }
        public string Maker
        {
            get {return maker; }
            set { maker = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
