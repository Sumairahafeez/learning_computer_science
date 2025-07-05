using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MountainBike b1 = new MountainBike(12, 4, 3, 35);
            b1.GetShow();
            b1.setSeatHeight(15);
            b1.ApplyBrake(5);
            Console.WriteLine("Mountain Bike having " + b1.GetCadence() + " is moving with speed " + b1.GetSpeed());
            Console.ReadKey();
        }
    }
}
