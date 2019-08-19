using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotech_Defense_Force
{
    public class Weapons
    {
        public virtual void Defense()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This weapon is used for defense");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
    public class GunPod : Weapons
    {
        public override void Defense()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This is not really used for defense..");
            Console.ResetColor();
            Console.ReadLine();
        }
        public void Looks()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GunPods are the basic weapon on a veritech fighter and are best for battleoid mode..");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class ReflexCannon : Weapons
    {
        public void Shoots()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The VF-1 Valkyrie is equipped with a power beam energy cannon...");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class NeutronSmissile : Weapons
    {
        public void handgun()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The Neutron-S Missile is a powerful against large aerial forces...");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class BeamCannon : Weapons
    {
        public void Stab()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The beam cannon is a standard weapon for Tirolian aerial forces.");
            Console.ResetColor();
            Console.ReadLine();
        }
    }

    public class PodMissiles : Weapons
    {
        public override void Defense()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Podmissles are used to force the enemy to scatter.");
            Console.ResetColor();
            Console.ReadLine();
        }
        public void PodMissilesB()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The Podmissles are used very effectively by the Tirolians.");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
