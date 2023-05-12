using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport {
    internal class Runway {
        public int Number;
        public Queue<string> PlaneQueue;        //contains all planes in queue for take off.

        public Runway(int nr) {
            Number = nr;
            PlaneQueue = new Queue<string>();

        }






    }
}
