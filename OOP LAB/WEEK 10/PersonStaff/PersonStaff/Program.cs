using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonStaff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff s1 = new Staff("Ali", "STAFF COLONY", "ABICS", 10000);
            Student st1 = new Student("Sumaira", "Girls Hostel", "CS", 2023, 23000);
            Console.WriteLine("Student: "+st1.GetName()+" "+st1.GetProgram()+","+st1.GetYear()+","+st1.ToString());
            Console.WriteLine("Staff: " + s1.GetName() + "," + s1.GetAddress() + "," + s1.GetSchool() + "," + s1.GetPay());
            Console.ReadKey();  
        }
    }
}
