using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport {
    internal class Plane {
        public int Id;
        public string model;
        public int passengerCapacity;
        public int productionYear;



        /**
        * 
        */
        public Plane(int nr, string mo, int cap, int year) {
            Id = nr;
            model = mo;
            passengerCapacity = cap;
            productionYear = year;

        }





    }
}
