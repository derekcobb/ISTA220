using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine($" a is {a}");
            changeAbyCopy(a);   //Calls a method and passes "a" as a parameter.
            Console.WriteLine($" a is still {a}");
            changeAbyRef(ref a);                             //reference is a memory address, here passing a memory address
            Console.WriteLine($" a is now {a}");
        }

        private static void changeAbyRef(ref int a)  //Only difference between methods is the ref declaration
        {
            Console.WriteLine($"      calling method changeAbyRef(ref a)");
            a = 666;
            Console.WriteLine($"      inside method changeAbyRef, a is {a}");
        }

        private static void changeAbyCopy(int a)
        {
            Console.WriteLine("      Calling method changeAbyCopy()");
            a = 666;
            Console.WriteLine($"     dinside changeAbyCopy, a is {a}");
        }
    }
}
