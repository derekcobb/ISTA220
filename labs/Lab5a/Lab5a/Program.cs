using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            Console.Write("Enter a decimal number to convert to octal: ");
            string input = Console.ReadLine();
            int dec = int.Parse(input);
            Console.WriteLine(dec);

            //Create variables
            int mod = 0;
            int factor = 1;
            int oct = 0;

            //Calculate output
            while (dec > 0)
            {
                mod = dec % 8;
                dec = dec / 8;
                oct += mod * factor;
                factor = factor * 10;
            }
            //Display output
        }
    }
}
