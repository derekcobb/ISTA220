using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = min(0);
            Console.WriteLine(total);
            total = min(1);
            Console.WriteLine(total);
            total = min(1, 2);
            Console.WriteLine(total);
            total = min(1, -1, 5, -3);
            Console.WriteLine(total);
            total = min(5, 2, 8, -11);
            Console.WriteLine(total);
        }
        private static int min(params int[] vars)
        {
            int min = vars[0];
            foreach (int e in vars)
                if (e < min)
                    min = e;
            return min;

        }
    }
}
