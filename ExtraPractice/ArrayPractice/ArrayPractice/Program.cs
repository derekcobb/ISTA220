using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.
            int [] numarr = new int[10]; // Create an empty array
            int i;                       // Declare variable i

            Console.Write("\nRead and print elements of an array.\n");
            Console.Write("--------------------------------------\n");
         Console.Write("Input 10 elements in the array:\n");

        for (i=0; i<10; i++)
        {
        Console.Write("element - {0} : ", i);
        numarr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("\nElements in the array are: ");
        for (i=0; i<10; i++)
        {
        Console.Write("{0}, ", numarr[i] );
        }
        Console.Write("\n");
       
        //2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order.
        int i, n;
        int[] a = new int[100];

        Console.Write("\nRead n number of values in an array and display it in reverse order.\n");
        Console.Write("-----------------------------------------------------------------------\n");

        Console.Write("Input the number of elements to store in the array.");
        n = int.Parse(Console.ReadLine());

                Console.Write("\nInput {0} number of elements in the array: \n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0}: ", i);
                    a[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("\nThe values stored in the array are: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(" {0}, ", a[i]);
                }

                Console.Write("\nThe values stored into the array in reverse are: ");
                for (i = n-1; i>=0; i--)
                {
                    Console.Write(" {0}| ", a[i]);
                }
                Console.Write("\n\n");
             */

            //3. Write a program in C# Sharp to find the sum of all elements of the array.
            /*
            int i, n, s = 0;
            int[] arr = new int[100];

            Console.Write("\nRead a number of values in an array and display their sum.\n");
            Console.Write("\n----------------------------------------------------------\n");

            Console.Write("Input the number of elements to store in the array: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\nInput {0} number of elements into the array.", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("\nelement - {0}, ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nThe values stored in the array are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n {0}, ", arr[i]);
            }

            for (i = 0; i < n; i++)
            {
                s += arr[i];
            }
            Console.Write("\n\nThe sum of all the values in the array is: {0}\n\n ", s);
            */

            // 4.Write a program in C# Sharp to copy the elements one array into another array.
            /*
            int n, i;
            int[] array = new int [100];
            int[] array2 = new int[100];

            Console.Write("\n\nCopy the elements one array into another array: \n");
            Console.Write("\n---------------------------------------------------------\n");

            Console.Write("\nInput the number of elements to be stored in the array: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\nInput {0} elements in the array: \n", n);
            for (i=0; i<n, i++)
            {
                Console.Write("element - {0}: ",i);
                array[i] = int.Parse(Console.ReadLine());
            }
             Copy elements of first array into second array.*/
             /*
            for(i=0; i<n; i++)
            {

            }
            */
            
        }
    }
}