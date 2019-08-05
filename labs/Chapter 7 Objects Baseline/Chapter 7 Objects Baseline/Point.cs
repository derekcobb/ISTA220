using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Objects_Baseline
{
    class Point
    {
        int x; // Field x of type int, Declared but not initialized. This "x" is an instance field. Accessed through the object.
        int y; // Field y of type int

        public Point() //this is a constructor, has same name as class, it intializes the fields
        {
            Console.WriteLine("Creating a point:");
            this.x = getParam("Please enter the X coordinate: "); //x is initialized using the keyword "this" which is C# uses for overloading. In current case "this" means this particular object
            this.y = getParam("Please enter the Y coordinate: "); //   
        }

        private int getParam(string v) //Private because it only has access to the Point Class, helper function
        {
            Console.Write(v);
            int p = int.Parse(Console.ReadLine()); // the method "ReadLine() reads what the user inputs through console. The string is taken and turned into an int whose value is assigned to "p"
            return p;                               // Returns "p"
        }

        public override string ToString()
        {
            return ($"Point: X = {this.x}, Y = {this.y}"); //returns a string representation of my point, $=an interpolated string
        }

        public double Distance(Point pt) //Method distance that takes the parameter Point pt
        {
            double inner = (Math.Pow(this.x - pt.x, 2) + Math.Pow(this.y - pt.y, 2)); // broke this step into two to better show process
            double distance = Math.Sqrt(inner);
            return distance;
        }
    }
}
