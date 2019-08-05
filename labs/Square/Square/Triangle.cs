using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Triangle
    {
        int sidea = 0;
        int sideb = 0;
        int sidec = 0;
        double area = 0.0;
        int perimeter = 0;

        public Triangle()
        {
            Console.WriteLine("Creating a triangle:");
            this.sidea = getSide("Enter the length of side a: ");
            this.sideb = getSide("Enter the length of side b: ");
            this.sidec = getSide("Enter the length of side c: ");
            

        }

        internal double getPerim()
        {
            int p = this.sidea + this.sideb + this.sidec;
            return p;
        }

        internal double getArea()
        {
            
            double x = (this.sidea + this.sideb + this.sidec) / 2;
            double a = Math.Sqrt((x - sidea) * (x - sideb) * (x - sidec) * x);
            return a;
            
        }

        private int getSide(string v)
        {
            Console.Write(v);
            return int.Parse(Console.ReadLine());
            //int s = int.Parse(Console.ReadLine());
            //return s;
        }
        public override string ToString()
        {
            return ($"Triangle: Side A = {this.sidea}, Side B = {this.sideb}, Side C = {this.sidec}"); //returns a string representation of my triangle, $=an interpolated string
        }
    }
}
