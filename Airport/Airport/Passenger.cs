using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport {
    internal class Passenger {
        public int Id;                  //social security number
        public string FirstName;
        public string LastName;
        public int Age;
        public string Nationality;
        
        public Passenger(int socials, string first, string last, int year, string nat) {
            Id = socials;
            FirstName = first;
            LastName = last;
            Age = year;
            Nationality = nat;

        }






    }
}
