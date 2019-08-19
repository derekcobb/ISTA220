using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotech_Defense_Force
{
    class Program
    {
        static void Main(string[] args)
        {
            Mission part1 = new Mission();
            part1.Intro();
            Console.WriteLine("Choose 1 to leave. Choose 2 to stay");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("The vehicle you hot-wired to escape in is hit by a stray missile " +
                      "you are thrown from you vehicle and get impaled on a broken pole." + "You are dead.");
                System.Environment.Exit(0);
            }
            else
                Console.WriteLine("You jump in the VF-1 Valkyrie and take off. ");

            Earth_Squadron B = new Earth_Squadron();
            Officer John = new Officer();
            Console.WriteLine("You join three other friendlies in combat");
            Console.WriteLine();
            John.Orders("You assist one fighter in destroying an enemy aircraft.");
            Enlisted E = new Enlisted();
            E.Brit();
            E.Reports();

            Console.WriteLine("Two more enemy squadrons of four are spotted in the distance..");
            Console.ReadLine();
            Chief C = new Chief();
            Warrior W = new Warrior();
            BeamCannon stick = new BeamCannon();
            PodMissiles newsheild = new PodMissiles();
            C.Point("Four enemy aircraft appear to be heading for you.");
            Console.WriteLine();

            Aircraft singing = new Aircraft();
            ZuluSong zuSong = new ZuluSong();
            BritSong brisong = new BritSong();

            singing.Sing();
            zuSong.Zsong();
            brisong.Sing();
            brisong.Bsong();


            Console.WriteLine($" One fighter has a skull on it.:");
            C.Yell();
            W.Run();
            W.Yell();
            Console.WriteLine("The enemy fighters are barind down you your are fast.");
            stick.Stab();
            newsheild.Defense();
            newsheild.PodMissilesB();

            Mission Part2 = new Mission();
            Part2.Middle();
            Weapons arms = new Weapons();
            GunPod G = new GunPod();
            ReflexCannon R = new ReflexCannon();
            NeutronSmissile NS = new NeutronSmissile();
            G.Defense();
            G.Looks();
            R.Defense();
            R.Shoots();
            NS.Defense();
            NS.handgun();

            Choose();

            Console.WriteLine("You fire you GunPod and Reflex Cannon to scatter some of the enemy.");
            John.Orders("You GundPod clips two enemy aircraft.");
            John.Orders("The Reflex Cannon cripples another.");

            Mission part3 = new Mission();
            part3.End();

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("THE END");
            zuSong.Disclaimer();
            part3.Disclaimer();

        }

        private static void Choose()
        {
            Console.WriteLine("Choose 1 for a GunPod. Choose 2 for a ReflexCannon. Choose 3 for a pistol Neutron-S missile");
            int choice2 = int.Parse(Console.ReadLine());
            switch (choice2)
            {
                case 1:
                    Console.WriteLine("You choose the GunPod... it is your standard armament but it may now be enough for the first wave . . ...");
                    break;
                case 2:
                    Console.WriteLine("You choose the ReflexCannon which is a good medium capability weapon.");
                    break;
                case 3:
                    Console.WriteLine("Good Choice! The Neutron-S missiles are a very effective weapon.");
                    break;
            }
            Console.WriteLine("Choose Another? 1 for Yes or 2 for No");
            int tryagain = int.Parse(Console.ReadLine());
            switch (tryagain)
            {
                case 1:
                    Choose();
                    break;
                case 2:
                    Console.WriteLine("Okay:");
                    break;
            }
        }

    }
}
