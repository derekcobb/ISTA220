using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotech_Defense_Force
{
    public class Earth_Squadron
    {
        public void Brit()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You are asked to join them in defending their sector.");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class Officer : Earth_Squadron
    {
        public void Orders(string order)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(order);
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class Enlisted : Earth_Squadron
    {
        public void Reports()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You oblige");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
