using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.UI
{
    internal class ConsoleUtility
    {
        public static int Menu()
        {
            int option;
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit ");
            Console.WriteLine("4. View Registered Students ");
            Console.WriteLine("5. View Students of a specific program");
            Console.WriteLine("6. Register Subjects for a specific student");
            Console.WriteLine("7. Calculate fees for all registered students");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Enter option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
