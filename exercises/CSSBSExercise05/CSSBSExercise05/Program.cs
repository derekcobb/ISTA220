using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSBSExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[5] { 1, 3, 5, 7, 9 };
            int[] C = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            int numberofelements = getNumberOfElements(A, B, C);
            Console.WriteLine($"Number of elements in array A, B, and C are as follows: {numberofelements}");
        }

        private static int getNumberOfElements(int[] A, int[] B, int[] C)
        {
            int count = 0; //countb = 0, countc = 0;
            foreach (int letter in A)
                count++;
            /*
            foreach (int letter in B)
                countb++;
            foreach (int letter in C)
                countc++;
                */
            return count;
        }
    }
}
