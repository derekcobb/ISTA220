using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotech_Defense_Force
{
    public class Tirolian_Squadrons
    {
        public void Yell()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Two of the enemy aircraft lock on to you.");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class Chief : Tirolian_Squadrons
    {
        public void Point(string direction)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(direction);
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class Warrior : Tirolian_Squadrons
    {
        public void Attack()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Four missiles are fired in your direction.");
            Console.ResetColor();
            Console.ReadLine();
        }

        public void Run()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You successfully dodge all four missiles.");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
