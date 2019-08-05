using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nThis is my triangle.");

            Triangle T1 = new Triangle();
            string s = T1.ToString();
            Console.WriteLine(s);

            double area = T1.getArea();
            double perim = T1.getPerim();
            Console.WriteLine($"Area is {area} and perimeter is {perim}");

            Console.WriteLine("\nThis is my rectangle.");

            Rectangle R1 = new Rectangle();
            string r = R1.ToString();
            Console.WriteLine(r);

            int areaR = R1.getArea();
            int perimR = R1.getPerim();
            Console.WriteLine($"Area is {areaR} and perimeter is {perimR}");

            Console.WriteLine("\nThis is my cude.");

            Cube C1 = new Cube();
            string c = C1.ToString();
            Console.WriteLine(c);

            double areaQ = C1.getArea();
            double volume = C1.getVolume();
            Console.WriteLine($"Sufrace area is {areaQ} and volume is {volume}");

        }
    }
}
