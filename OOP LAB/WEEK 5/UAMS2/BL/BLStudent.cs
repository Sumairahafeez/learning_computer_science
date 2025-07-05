using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UAMS2.UL;

namespace UAMS2
{
    internal class BLStudent
    {
        public string Name;
        public int age;
        public float FSCMarks;
        public float EcatMarks;
        public float merit;
        public  List<BLDegreeProgram> degreePreferances = new List<BLDegreeProgram>();
        public  static List<BLSubject> registerSub = new List<BLSubject>();
        public BLDegreeProgram programReg;
        public BLStudent(string name, int age, float fSCMarks, float ecatMarks)
        {
            Name = name;
            this.age = age;
            FSCMarks = fSCMarks;
            EcatMarks = ecatMarks;

            

        }
        public bool AddPreferances(string degName)
        {
            bool flag = false;
            foreach (BLDegreeProgram d in DegreeProgramCRUD.degreesList)
            {
                if (DegreeProgramCRUD.degreesList.Contains(d) && degName == d.DegreeTitle)
                {
                    flag = true;
                    degreePreferances.Add(d);

                }
            }
            return flag;
        }
        public bool AddProgram(string ProgramName)
        {
            foreach(BLDegreeProgram d in degreePreferances)
            {
                if(ProgramName == d.DegreeTitle)
                {
                    programReg = d;
                    return true;
                }
            }
            return false;
        }
        public int GetCreditHours()
        {
            int Count = 0;
            foreach (BLSubject i in registerSub)
            {
                Count += i.CreditHours;
            }
            return Count;
        }
        public void CalculateMerit()
        {
            merit = (FSCMarks * 0.06f) + (EcatMarks * 0.04f);
        }
        public  float CalculateFee()
        {
            float fee = 0;
            for (int i = 0; i < registerSub.Count; i++)
            {
                fee += registerSub[i].SubjectFee;
            }
            return fee;
        }
        public  bool RegisterSubject(BLSubject s)
        {
            int stCH = programReg.getCreditHours();
            if (programReg != null && programReg.isSubjectExists(s) && stCH + s.CreditHours <= 9)
            {
                registerSub.Add(s);
                return true;
            }
            return false;
        }
        public bool AddSubject( string code)
        {
            bool flag = false;
            
            foreach (BLSubject j in programReg.SubjectsTaught)
            {
               
                   registerSub.Add(j);
                    flag = true;
                    break;
                
            }
            return flag;
        }
    }
}
