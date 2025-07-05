using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS2.UL;

namespace UAMS2
{
    internal class DegreeProgramCRUD
    {
       public static List<BLDegreeProgram> degreesList= new List<BLDegreeProgram>();
        public void AddDegree(SubjectCRUD S)
        {
            degreesList.Add(ULDegree.AddDegree(S));
        }
        public void ViewDegreePrograms()
        {
            foreach (BLDegreeProgram d in degreesList)
            {
                Console.WriteLine(d.DegreeTitle);
            }
        }
        public static bool ReadDataFromFile()
        {   string path = "D:\\2nd semester\\PD\\WEEK 5\\UAMS2\\FILES\\Degrees.txt";
            StreamReader sr = new StreamReader(path);
            string record;
            if(File.Exists(path))
            {
                while((record =sr.ReadLine())== null)
                {
                    string[] splitDegree = record.Split(',');
                    string Title = splitDegree[0];
                    int Durantion = int.Parse(splitDegree[1]);
                    int Seats = int.Parse(splitDegree[2]);
                    string[] subjectsTaught = splitDegree[3].Split(';');
                    List<BLSubject> subjects = new List<BLSubject>();
                    for(int i = 0; i<subjectsTaught.Length; i++)
                    {
                        BLSubject s = SubjectCRUD.ISSubjectExists(subjectsTaught[i]);
                        if(s != null)
                        {
                            if(!subjects.Contains(s))
                            {
                                subjects.Add(s);
                            }
                        }
                    }
                    BLDegreeProgram D = new BLDegreeProgram(Title, Durantion, Seats, subjects);
                    degreesList.Add(D);
                }
                sr.Close();
                return true;
            }
            return false;
        }
        public static void WriteDataToFile( BLDegreeProgram d) 
        {   string path = "D:\\2nd semester\\PD\\WEEK 5\\UAMS2\\FILES\\Degrees.txt";
            StreamWriter Degree = new StreamWriter(path,true);
            string DegreeSub = "";
           
            for (int i = 0; i<d.SubjectsTaught.Count; i++)
            {
                DegreeSub += (d.SubjectsTaught[i].SubjectCode);
                if(i != d.SubjectsTaught.Count-1)
                {
                    DegreeSub += ";";
                }
            }
            if(d.SubjectsTaught.Count == 1) { DegreeSub += d.SubjectsTaught[d.SubjectsTaught.Count-1]; }
           
            Degree.WriteLine(d.DegreeTitle + "," + d.Duration + "," + d.Seats + ","+DegreeSub);
            Degree.Flush();
            Degree.Close();
        }
        public static BLDegreeProgram ISDegreeExists(string name)
        {
            foreach(BLDegreeProgram B in degreesList)
            {
                if(B.DegreeTitle == name)
                {
                    return B;
                }
            }
            return null;
        }
       
    }
}
