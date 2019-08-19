using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicles
    {
        public void StartEngine(string noiseToMakeWhenStarting) //Instance method
        {
            Console.WriteLine($"Starting engine: {noiseToMakeWhenStarting}");
        }
        public void StopEngine(string noiseToMakeWhenStopping)
        {
            Console.WriteLine($"Stopping engine: {noiseToMakeWhenStopping}");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Default implementation of the Drive method");
        }
    }
}
