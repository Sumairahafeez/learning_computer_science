using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS2.UL
{
    internal class ULDegree
    {
       public static BLDegreeProgram AddDegree()
        {   List<BLSubject> subjects = new List<BLSubject>();
            Console.WriteLine("Enter The Degree Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seats for this program: ");
            int seats = int.Parse(Console.ReadLine());
            
            subjects = GetSubjects();
            BLDegreeProgram d = new BLDegreeProgram(title, duration, seats,subjects);
            return d;
        }
        public static List<BLSubject> GetSubjects()
        {
            List<BLSubject> subjects = new List<BLSubject>();
            Console.WriteLine("Enter the number of Subjects in your degree: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Enter Subject Code: ");
                string code = Console.ReadLine();
                Console.WriteLine("Enter Subject Credit Hours: ");
                int CH = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Subject Type: ");
                string type = Console.ReadLine();
                Console.WriteLine("Enter Subject Fee: ");
                float fee = int.Parse(Console.ReadLine());
                BLSubject S = new BLSubject(code, CH, type, fee);
                subjects.Add(S);
                
                
            }
            return subjects;
        }

    }
}
