using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobbFarm
{
    class Fowls
    {
        public Fowls()
        {
            Console.WriteLine("Say Hello!");
            
        }
        public void Name(string Name, string Sound, string Act )
        {
            Console.WriteLine($"Hello I am a {Name}\nI go {Sound}\nand I like to {Act}. ");
        }

        
    }
}

        
