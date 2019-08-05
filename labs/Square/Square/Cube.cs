using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Cube
    {
        double sideQ = 0.0;
        //double SurfaceArea = 0.0;
        //double volume = 0.0;

        public Cube()
        {
            Console.WriteLine("\nCreating a cube:");
            sideQ = getSide("Enter the length of q: ");
            
        }

        internal double getArea()
        {
            return Math.Pow(sideQ, 2) * 6;
        }

        internal double getVolume()
        {
            return Math.Pow(sideQ, 3);
        }
        private int getSide(string v)
        {
            Console.Write(v);
            return int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return ($"Cube: Side Q = {sideQ}"); //returns a string representation of my triangle, $=an interpolated string
        }
    }
}
