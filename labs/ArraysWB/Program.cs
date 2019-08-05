using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysWB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //printArray(A);
            //printFlatArray(A);
            //printColumnArray(A);
            int[] B = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //createRowMatrix(B);
            //createTransposeRowMatrix(B);
            //myReverse(B);
            //myRotate("L", 2, B);
            //myRotate("R", 4, B);
            int[] ages = { 69, 42, 21, 23, 29, 42, 33, 33, 37, 33, 26 };
            bubbleSort(ages);
        }

        private static void bubbleSort(int[] ages)
        {
            Console.WriteLine("This is bubble sort");
            Console.WriteLine("The original array");
            foreach (int e in ages)
                Console.WriteLine($"{e} ");
            for (int i = 0; i < ages.Length - 1; i++)
            {
                for (int j = i+1; j < ages.Length -1; j++)
                {
                    if(ages[i] > ages[j])
                    {
                        int temp = ages[i];
                        ages[i] = ages[j];
                        ages[j] = temp;
                    }
                }
            }
            Console.WriteLine("The sorted array");
            foreach (int e in ages)
                Console.Write($" {e} ");
        }
        
        /*
        private static void myRotate(string v1, int v2, int[] b)
        {
            int len = b.Length;
            if (direction == "R")
                amount = len - amount;
            for (int i = 0; i < len; i++)
                Console.Write($" {b[(i + amount) % len]}");
            Console.WriteLine();
        }

        int[,] A = new int[3, 3];
            for (int i = 0; i< 9; i++)
                A[i / 3, i % 3] = B[i];
            printArray(A);

            for (int i = B.Length - 1; i >= 0; i--)
                Console.WriteLine($" {B[i]} ");
            Console.WriteLine();

        private static void printArray(int[,] a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write($" {arr[i, j]} ");
                Console.WriteLine();
            }
        }
        */
    }
}