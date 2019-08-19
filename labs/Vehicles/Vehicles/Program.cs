using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");

            Console.WriteLine();
            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");

            Console.WriteLine();
            Console.WriteLine("Journey by ship");
            Boat myBoat = new Boat();
            myBoat.StartEngine("Sirens");
            myBoat.setSail();
            myBoat.Drive();
            myBoat.anchor();
            myBoat.StartEngine("whoosh");

            Console.WriteLine("\nTesting polymorphism");
            Vehicles v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();
            v = myBoat;
            v.Drive();

        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
