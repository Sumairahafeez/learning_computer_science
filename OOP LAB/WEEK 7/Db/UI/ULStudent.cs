using Db.BL;
using Db.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.UI
{
    internal class ULStudent
    {
        public static BLStudent AddStudent()
        {
            Console.WriteLine("Enter the name of Student: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the age of Student: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your fsc Marks: ");
            float FSCMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your ecat Marks: ");
            float EcatMarks = float.Parse(Console.ReadLine());
            BLStudent s = new BLStudent(Name, age, FSCMarks, EcatMarks);

            GetDegreeProgramList(s);

            return s;
        }
        public static BLDegreeProgram GetDegreeProgramList(BLStudent S)
        {
            bool flag = false;
            Console.WriteLine("Enter your number of preferances: ");
            int no = int.Parse(Console.ReadLine());

            for (int i = 0; i < no; i++)
            {
                Console.WriteLine("Enter your degree Preferance: ");
                string degName = Console.ReadLine();
                flag = S.AddPreferances(degName);
                if (flag == false)
                {
                    Console.WriteLine("Enter a valid degree program");
                    i--;
                    if (i < 0)
                    {
                        break;
                    }

                }
                
            }

            return null;
        }
        public static void ViewStudents(StudentCRUD St)
        {
            Console.WriteLine("Name \t FSC Marks \t Ecat Marks \t Age");
            foreach (BLStudent s in StudentCRUD.studentList)
            {
                if (s.programReg != null)
                {
                    Console.WriteLine(s.Name + "\t" + s.FSCMarks + "\t" + s.EcatMarks + "\t" + s.age);

                }



            }
            Console.ReadKey();
        }
        public static void PrintStudents(StudentCRUD st)
        {
            foreach (BLStudent s in st.sortedStudent)
            {
                Console.WriteLine(s.Name);
            }
            Console.ReadKey();
        }
        public static void RegisterProgram(StudentCRUD St)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            foreach (BLStudent s in StudentCRUD.studentList)
            {
                if (s.Name == name)
                {
                    Console.WriteLine("Enter the program you want to pursue: ");
                    string prog = Console.ReadLine();
                    bool flag = s.AddProgram(prog);
                    
                    if (flag == false)
                    {
                        Console.WriteLine("Enter a valid degree program");
                        Console.ReadKey();

                    }
                    StudentCRUD.StoreData(s);
                }
            }
            
        }
        public static void ViewStudentInDegree(StudentCRUD St)
        {
            Console.WriteLine("Enter the degree: ");
            string degName = Console.ReadLine();
            Console.WriteLine("Name \t FSC Marks \t Ecat Marks \t Age");
            foreach (BLStudent s in StudentCRUD.studentList)
            {
                if (s.programReg != null)
                {
                    if (degName == s.programReg.DegreeTitle)
                    {
                        Console.WriteLine(s.Name + "\t" + s.FSCMarks + "\t" + s.EcatMarks + "\t" + s.age);
                    }
                }




            }
            Console.ReadKey();
        }
        public static void Register(StudentCRUD St)
        {
            Console.WriteLine("Enter the student name: ");
            string sName = Console.ReadLine();
            BLStudent s = St.StudentPresent(sName);
            
            if (s != null)
            {
                int stID = StudentCRUD.GetStudentID(sName);
                ViewSubjects(s);
                RegisterSubject(s,stID);
            }
        }
        public static void ViewSubjects(BLStudent s)
        {
            if (s.programReg != null)
            {
                Console.WriteLine("Sub Code \t Sub Type");
                foreach (BLSubject i in s.programReg.SubjectsTaught)
                {
                    Console.WriteLine(i.SubjectCode + "\t" + i.SubjectType);
                }
            }
            Console.ReadKey();
        }
        public static void RegisterSubject(BLStudent s, int stID)
        {
            Console.WriteLine("Enter how many subjects you want to register: ");
            int no = int.Parse(Console.ReadLine());
            for (int i = 0; i < no; i++)
            {
                Console.WriteLine("Enter the subject code: ");
                string code = Console.ReadLine();
                bool check = s.AddSubject(code);
                if (check == false)
                {
                    Console.WriteLine("Enter a valid subject");
                    i--;
                    if (i < 0)
                    {
                        break;
                    }
                }
                if (check == true)
                {
                    Console.WriteLine("Subject Registered Succesfully!");
                    s.AddSubject(code);
                    SubjectCRUD.AddStudentID(stID,code);
                }
            }
        }
        public static void ShowFee(StudentCRUD St)
        {
            foreach (BLStudent s in StudentCRUD.studentList)
            {
                if (s.programReg != null)
                {
                    Console.WriteLine("Student " + s.Name + " has " + s.CalculateFee() + " fees.");
                }
            }
            Console.ReadKey();
        }
    }
}
