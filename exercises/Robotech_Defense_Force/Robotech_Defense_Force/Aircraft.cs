using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotech_Defense_Force
{
    public class Aircraft
    {
        public virtual void Disclaimer()
        {
            Console.WriteLine("Disclaimer:");
            Console.ReadLine();
        }
        public virtual void Sing()
        {
            Console.WriteLine("The enemy assumes two Vee formations ");
            Console.ReadLine();
        }
    }

    public class BritSong : Aircraft
    {
        public override void Sing()
        {
            Console.WriteLine("You and the fighters you joined try to gain altitude on the enemy fighters. ");
            Console.ReadLine();
        }
        public void Bsong()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Two more friendlies join your formation " +
                "You and another aircraft take the highest position to dive on aircraft " +
                "The other four will try to scatter the left formation");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class ZuluSong : Aircraft
    {
        public override void Disclaimer()
        {
            Console.WriteLine("Disclaimer: This is loosely based on Episode 1 of the Robotech series " +
                "this is an old Japanese anime.");
            Console.ReadLine();
        }
        public void Zsong()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The enemy formation looks strong " +
                "the lead enemy aircraft looks fierce");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
