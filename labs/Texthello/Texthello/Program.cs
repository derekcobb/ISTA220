//Name: Lab 01a
//Author: Derek cobb
//Date: July 3, 2019

using System;

namespace Texthello
{    class Program
    {        static void Main(string[] args)
            {
                Console.WriteLine("Hello MSSA");
                int numberone = 42, numbertwo = 7;
                int sum = numberone + numbertwo;

                Console.WriteLine("The sum of " + numberone + " and " + numbertwo + " is " 
                    + sum + ".");

                Console.WriteLine("Enter a number:");
                string a = Console.ReadLine();
                Console.WriteLine("Enter another number:");
                string b = Console.ReadLine();
                Console.WriteLine("String " + a + b);
                numberone = int.Parse(a);
                numbertwo = int.Parse(b);
                sum = numberone + numbertwo;
                Console.WriteLine("Int " + sum);




            }
    }
}
