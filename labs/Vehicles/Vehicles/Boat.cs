using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Boat : Vehicles
    {
        public void setSail()
        {
            Console.WriteLine("Setting sail.");
        }
        public void anchor()
        {
            Console.WriteLine("Drop anchor");
        }
        public override void Drive()
        {
            Console.WriteLine("Sailing");
        }

    }
}
