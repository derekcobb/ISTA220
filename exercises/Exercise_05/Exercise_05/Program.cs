using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayA = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = new int[5] { 1, 3, 5, 7, 9 };
            int[] ArrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine("Part A: Counting, Summing, Computing the Mean");
            double meanA = findAverage(ArrayA);
            double meanB = findAverage(ArrayB);
            double meanC = findAverage(ArrayC);

            Console.WriteLine($"The average for the first array is: {meanA}");
            Console.WriteLine($"The average for the second array is: {meanB}");
            Console.WriteLine($"The average for the third array is:{meanC}");
            Console.ReadLine();

            Console.WriteLine("Part B: Reversing Arrays");
            Console.WriteLine("The reverse of the first array is");
            Reverse(ArrayA);
            Console.ReadLine();
            Console.WriteLine("The reverse of the second array is");
            Reverse(ArrayB);
            Console.ReadLine();
            Console.WriteLine("The reverse of the third array is");
            Reverse(ArrayC);
            Console.ReadLine();

            Console.WriteLine("Part C: Rotating Arrays");
            int left = -1;
            int right = +1;
            Rotate(left, 2, ArrayA);
            Rotate(right, 2, ArrayB);

            Console.WriteLine("Part D: Sorting Arrays");
            Sort(ArrayC);
            Console.ReadLine();
        }

        private static void Sort(int[] numbers)
        {
            int temp;
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1]; 
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
            }
            foreach (int number in numbers)
                Console.Write($"{number}");
        }

        private static void Rotate(int direction, int places, int[] numbers)
        {
            int last = numbers[0];
            int temp = numbers[places];
            if (direction == -1)
            {
                for (int x = 0; x <= numbers.Length - 1; x++)

                    Console.Write($"l{numbers[(x + places) % numbers.Length]}.");  
            }

            else if (direction == +1)
            {
                for (int x = 0; x < places; x++)
                {
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        numbers[i] = numbers[i + 1];
                        if (numbers[i] == numbers.Length - 1)
                            numbers[numbers.Length - 1] = last;
                    }
                }
                foreach (int number in numbers)
                    Console.WriteLine($"right {number}");
            }
        }

        private static double findAverage(int[] numbers)
        {
            double sum = 0;

            foreach (double number in numbers)
            {
                sum += number;
            }
            double mean = sum / numbers.Length;
            return mean;
        }
        private static void Reverse(int[] numbers)
        {
            for (int n = numbers.Length - 1; n >= 0; n--)
            {
                Console.Write($"{numbers[n]} | ");
            }
        }
    }
    }
