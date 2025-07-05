using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Console.WriteLine(c1.ToString()+"Volume: "+c1.GetVolume());
            Cylinder c2 = new Cylinder(12);
            Console.WriteLine(c2.ToString()+ "Volume: " + c2.GetVolume());
            Cylinder c3 = new Cylinder(13,3);
            Console.WriteLine(c3.ToString() + "Volume: " + c3.GetVolume());
            Console.WriteLine();
            Cylinder c4 = new Cylinder(14,4,"Green");
            Console.WriteLine(c4.ToString() + "Volume: " + c4.GetVolume());
            Console.ReadKey();
        }
    }
}
