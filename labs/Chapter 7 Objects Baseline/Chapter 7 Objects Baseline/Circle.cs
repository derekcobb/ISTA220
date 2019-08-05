using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Objects_Baseline
{
    class Circle
    {
        Point center;
        int radius;

        public Circle()
        {
            Console.WriteLine("Creating a circle");
            this.center = getCenter("Please enter a point for center: ");
            this.radius = getRad("Please enter the radius: ");
        }

        public override string ToString()
        {
            return $"Circle: center = {this.center}, and radius ={this.radius} ";
        }
        private int getRad(string prompt)
        {
            Console.Write(prompt);
            int r = int.Parse(Console.ReadLine());
            return r;
        }

        private Point getCenter(string v)
        {
            Console.WriteLine(v); // 
            Point c = new Point();
            return c;
        }

        public double getArea()
        {
            double a = Math.PI * Math.Pow(this.radius, 2);
            return a;
        }
         public double GetCircum()
        {
            double c = 2 * Math.PI * radius;
            return c;
        }
    }
}
