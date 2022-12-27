using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSpecsApplication
{
    class Vehicle
    {

        public Vehicle()
        {
        }

        public Vehicle(string make, string model, string year)
        {

            this.make = make;
            this.model = model;
            this.year = year;

        }

        public string make
        {
            set { make = value; }
            get { return make; }

        }
        public string model
        {
            set { model = value; }
            get { return model; }
        }
        public string year
        {
            set { year = value; }
            get { return year;  }
        }

        public void Accelerate()
        {
        }
        public void Decelerate()
        {
        }
        public void Drive()
        {
        }
        public void Start()
        {
        }
        public void Stop()
        {
        }


    }
}
