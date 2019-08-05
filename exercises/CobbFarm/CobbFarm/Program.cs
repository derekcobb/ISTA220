using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobbFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cobb Farm");

            Fowls duck = new Fowls();
            duck.Name("Daffy", "Quack", "Swim");

            Fowls rooster = new Fowls();
            rooster.Name("Foghorn Leghorn", "Crow", "Talk");

            Fowls canary = new Fowls();
            canary.Name("Tweety", "Tweet", "Mess with cats");

            Fowls pecker = new Fowls();
            pecker.Name("Woody", "Ha-ha-ha-HAAAAA HA", "Peck");


        }
    }
}
