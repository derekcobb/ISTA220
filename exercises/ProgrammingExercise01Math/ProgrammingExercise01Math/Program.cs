using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercise01Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.0, y = 0.0, z = 0.0;
            double circum = 0.0, area = 0.0;
            double volume = 0.0;

            Console.Write("The Circumference of a circle.");
            Console.Write("\nPlease enter your radius: ");
            x = double.Parse(Console.ReadLine());

            circum = 2 * Math.PI * x;
            Console.WriteLine($"The circumference is {circum}");

            Console.Write("The Area of a circle.");
            Console.Write("\nPlease enter your radius: ");
            y = double.Parse(Console.ReadLine());

            area = (Math.PI * Math.Pow(y,2));
            Console.WriteLine($"The area is {area}");

            Console.Write("The Volume of a sphere.");
            Console.Write("\nPlease enter your radius: ");
            z = double.Parse(Console.ReadLine());

            volume = ((1.33) * Math.PI * Math.Pow(z, 3) * (0.5));
            Console.WriteLine($"The volume is {volume}");

            //The are of a triangle give the lenght of the sides.

            //Solving a quadratic equation

        }
    }
}
