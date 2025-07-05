using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS2
{
    internal class StudentCRUD
    {
        public static List<BLStudent> studentList = new List<BLStudent>();
       public  List<BLStudent> sortedStudent = new List<BLStudent>();
        public  void AddStudent()
        {
           
            studentList.Add(ULStudent.AddStudent());
        }
        public  void SortStudentsAccordingToMerit()
        {
            
            foreach (BLStudent student in studentList)
            {
                student.CalculateMerit();
            }
            sortedStudent = studentList.OrderByDescending(o => o.merit).ToList();
           
        }
       public  BLStudent StudentPresent(string name)
        {
            foreach (BLStudent s in studentList)
            {
                if (name == s.Name && s.programReg != null)
                {
                    return s;
                }
            }
            return null;
        }
        /*
        public static void StoreData(BLStudent student)
        {
            string path  = "D:\\2nd semester\\PD\\WEEK 5\\UAMS2\\FILES\\Students.txt";
            StreamWriter s = new StreamWriter(path,true);
            string degreeNames="";
           
            for(int i = 0; i<student.degreePreferances.Count; i++)
            {
               degreeNames +=student.degreePreferances[i].DegreeTitle;
                if(i != student.degreePreferances.Count-1)
                {
                    degreeNames += ";";
                }
            }
            if(student.degreePreferances.Count == 1)
            {
                degreeNames = degreeNames + student.degreePreferances[student.degreePreferances.Count-1];
            }
            
            string regSub="";
            for (int i = 0; i<student.registerSub.Count; i++)
            {
                regSub = regSub + student.registerSub[i].SubjectCode ;
                if (i != student.registerSub.Count-1)
                {
                    regSub += "-";
                }
            }
            if(student.registerSub.Count == 1 )
            {
                regSub = regSub + student.registerSub[student.registerSub.Count-1];
            }
            
            s.WriteLine(student.Name + "," + student.age + "," + student.FSCMarks + "," + student.EcatMarks + "," + student.merit + ","+regSub+","+degreeNames);
            s.Flush();
            s.Close();
        }
        public static bool ReadData()
        {
            string path = "D:\\2nd semester\\PD\\WEEK 5\\UAMS2\\FILES\\Students.txt";
            StreamReader st = new StreamReader(path);
            string record;
            if(File.Exists(path))
            {
                while((record = st.ReadLine()) != null)
                {
                    string[] splitStudent = record.Split(',');
                    string name = splitStudent[0];
                    int age = int.Parse(splitStudent[1]);
                    float FSCMarsk = float.Parse(splitStudent[2]);
                    float EcatMarks = float.Parse((splitStudent[3]));
                    int merit = int.Parse((splitStudent[4]));
                    string[] splitPreferance = splitStudent[5].Split(';') ;
                    List<BLDegreeProgram> preferances = new List<BLDegreeProgram>();
                    for(int i = 0; i<splitPreferance.Length; i++)
                    {
                        BLDegreeProgram d = DegreeProgramCRUD.ISDegreeExists(splitPreferance[i]);
                        if(d != null)
                        {
                            if(! preferances.Contains(d))
                            {
                                preferances.Add(d);
                            }

                        }
                    }
                    string[] splitSubjects = splitStudent[6].Split('-') ;
                    List<BLSubject> subjects = new List<BLSubject>();
                    for(int i = 0; i<splitSubjects.Length; i++)
                    {
                        BLSubject s = SubjectCRUD.ISSubjectExists(splitSubjects[i]);
                        if(s != null)
                        {
                            if(! subjects.Contains(s))
                            {
                                subjects.Add(s);
                            }
                        }
                    }
                    BLStudent stu = new BLStudent(name, age, FSCMarsk, EcatMarks, merit, preferances, subjects);
                    studentList.Add(stu);

                }
                st.Close();
                return true;
            }
            return false;
        }
        */
       
    }
}
