using Db.DL;
using Db.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Db
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubjectCRUD subject = new SubjectCRUD();
            StudentCRUD s = new StudentCRUD();
            DegreeProgramCRUD d = new DegreeProgramCRUD();
            SubjectCRUD.ReadData();
            StudentCRUD.ReadData();
            DegreeProgramCRUD.ReadData();
            int op = 0;
            do
            {
                op = ConsoleUtility.Menu();
                Console.Clear();
                
                if (op == 1)
                {

                    s.AddStudent();
                    ULStudent.RegisterProgram(s);
                }
                
                if (op == 2)
                {
                    d.AddDegree(subject);



                }
                
                if (op == 3)
                {
                    s.SortStudentsAccordingToMerit();

                    ULStudent.PrintStudents(s);
                }
                if (op == 4)
                {
                    ULStudent.ViewStudents(s);
                }
                if (op == 5)
                {
                    ULStudent.ViewStudentInDegree(s);
                }
                if (op == 6)
                {
                    ULStudent.Register(s);
                }
                if (op == 7)
                {
                    ULStudent.ShowFee(s);
                }
                


            }
            while (op != 8);

        }
    }
}
