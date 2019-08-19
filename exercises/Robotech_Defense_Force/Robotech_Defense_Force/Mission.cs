using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotech_Defense_Force
{
    public class Mission
    {
        public void Intro()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("The alien space craft has finally been restored by the newly formed United Earth Government.");
            Console.ReadLine();
            Console.WriteLine("You are Rick Hunter who has traveled out to see the inaugural flight and catch up with your big brother.");
            Console.ReadLine();
            Console.WriteLine("While performing some stunt maneuvers on your way into the airspace of Macross City you see two aircraft in the distance get shot down.");
            Console.ReadLine();
            Console.WriteLine("The sky lights up with fire as strange ships appear from high in the sky. ");
            Console.ReadLine();
            Console.WriteLine("Your aircraft is hit by shrapnel and you crash land on an airstrip that has not be damaged yet.");
            Console.ReadLine();
            Console.WriteLine("You see one of the new aircraft that the Earth Government's military has designed that you receive training on at the academy.");
            Console.ReadLine();
            Console.WriteLine("It's fully armed and you know how to fly. There are not enough pilots in the sky to defend and they could use your help.");
            Console.ReadLine();
            Console.WriteLine("Which do you choose?");
            Console.ReadLine();
            Console.ResetColor();
        }

        public void Middle()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You have to choose appropriate armaments to suceed in your attack. " +
                "Each one is best for a specific job: ");

            Console.ReadLine();
            Console.ResetColor();
        }

        public void End()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("The fighting goes on for several hours.");
            Console.ReadLine();
            Console.WriteLine("Just when it looked like the fighting would never end, the main gun of the main battle ships takes out a critical enemy airship. ");
            Console.ReadLine();
            Console.WriteLine("You add all of the other fighters near and far have defended Macross City for now.");
            Console.ReadLine();
            Console.WriteLine("You need to land to rearm and recover. ");
            Console.ReadLine();
            Console.WriteLine("There is no telling when the Tirolians will try another attack though they suffered heavy losses.");
            Console.ReadLine();
            Console.ResetColor();
        }
        public void Disclaimer()
        {
            Console.WriteLine("Disclaimer: Robotech came out in 1985" +
                " It has had three variations of the story.");
        }
    }
}
