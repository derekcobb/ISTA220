﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double dailyRate = readDouble("Enter your daily rate: ");
            int noOfDays = readInt("Enter the number of days: ");
            writeFee(calculateFee(dailyRate, noOfDays));
        }
        */
        static void Main(string[] args)
        {
            double dailyRate = readDouble("Enter your daily rate: ");
            int noOfDays = readInt("Enter the number of days: ");
            writeFee(calculateFee(dailyRate, noOfDays));
        }

        private static double calculateFee(double dailyRate, int noOfDays)
        {
            return dailyRate * noOfDays;

        }

        private static void writeFee(double v)
        {
            Console.WriteLine($"The consultant's fee is: {v * 1.1}");
        }

        private static int readInt(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        private static double readDouble(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();
            return double.Parse(line);
        }
    }
}