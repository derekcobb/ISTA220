using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Objects_Baseline
{
    class Program
    {
        static void Main(string[] args) //Static creates a class method, void means nothing is returned of the Main method
        {
            Console.WriteLine("This is Chapter7Program"); //There are many ways to create a class..

            Point point = new Point(); //Point = Type/class, point = variable "new Point()" is a constructor
            string mypt = point.ToString(); //ToString is an instance method so I have to access through object
            Console.WriteLine(mypt);

            Point p2 = new Point();
            mypt = p2.ToString();
            Console.WriteLine(mypt);

            //get the distance between the two points
            double d = point.Distance(p2);
            Console.WriteLine($"The distance between p1 and p2 is {d} ");

            //this creates a circle
            Circle circle = new Circle();
            string des = circle.ToString();
            Console.WriteLine(des);
            double area = circle.getArea();
            double circum = circle.GetCircum();

            Console.WriteLine($"The area is {area} and circumference is {circum}");

        }
    }
}
