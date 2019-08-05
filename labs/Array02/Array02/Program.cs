using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 29, 23, 21, 42, 33, 33, 26, 33, 37, 69, 42 };
            int numberofelements = getNumberOfElements(ages);
            Console.WriteLine($"Number of elements in ages is {numberofelements}");
            int youngest = getYoungest(ages);
            Console.WriteLine($"The youngest age is {youngest}");
            int oldest = getOldest(ages);
            Console.WriteLine($"The oldest age is {oldest}");
            int numberOfOdds = getNumberOfOdds(ages);
            Console.WriteLine($"The numberOfOdds ages is {numberOfOdds}");
            int numberofEvens = getNumberOfEvens(ages);
            Console.WriteLine($"The numberOfEven ages is {numberofEvens}");
            int numberOfDuplicates = getNumberOfDuplicates(ages);
            Console.WriteLine($"The numberOfDuplicate ages is {numberOfDuplicates}");
            //int[] duplicates //Create a new array to take the duplicates into it



        }

        private static int getNumberOfDuplicates(int[] ages)
        {
            int duplicates = 0;
            for(int i = 0; i < ages.Length; i++)
            {
                for (int j = i + 1; j < ages.Length; j++)
                {
                    if (ages[i] == ages[j])
                        duplicates++;
                }
            }
            return duplicates;
        }

        private static int getNumberOfEvens(int[] ages)
        {
            int evens = 0;
            foreach (int age in ages)
                if (age % 2 == 0)
                    evens++;
            return evens;
        }

        private static int getNumberOfOdds(int[] ages)
        {
            int odds = 0;
            foreach (int age in ages)
                if (age % 2 == 1)
                    odds++;
            return odds;
        }

        private static int getOldest(int[] ages)
        {
            int old = ages[0];
            foreach (int a in ages)
                if (a > old)
                    old = a;
            return old;
        }

        private static int getYoungest(int[] ages)
        {
            int y = ages[0];
            foreach (int age in ages)
                if (age < y)
                    y = age;

            return y;
        }

        private static int getNumberOfElements(int[] ages)
        {
            int count = 0;  //Always initialize your variable.
            foreach (int age in ages)
                count++;
            return count;
        }
    }
}
