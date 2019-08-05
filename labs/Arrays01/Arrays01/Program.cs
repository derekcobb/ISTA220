using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 }; 
            int len = A.Length;
            Console.WriteLine($"The variable [len] is {len}");

            for (int i = 0; i < len; i++)
                Console.WriteLine(i);
            Console.WriteLine("--------------------------" );
            for (int i = 0; i < len; i++)
                Console.WriteLine(A[i]);
            Console.WriteLine("--------------------------");
            foreach (int i in A)
                Console.WriteLine(i);
            Console.WriteLine("--------------------------");

            string sentence = "Once for every man and nation";
            foreach (char c in sentence)
                Console.WriteLine(c);
            Console.WriteLine();

            //int[] B = A;
            //create a deep copy of A named B
            int[] B = new int[len];
            for (int i = 0; i < len; i++)
                B[i] = A[i];
            foreach (int i in B)
                Console.WriteLine(i);
            B[5] = -123456;
            Console.WriteLine("--------------------------");
            for (int i = 0; i < len; i++)
                Console.WriteLine($"A: {A[i]}, B: {B[i]}");

            Console.WriteLine("--------------------------");


            int[] C = { 2, 4, 6, 8, 10 };

            int leng = C.Length;
            Console.WriteLine($"The variable [len] is {leng}");

            foreach (int pin in C)
            {
                Console.WriteLine(pin);
            }







        }
    }
}
