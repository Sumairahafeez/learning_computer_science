using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UAMS2.UL;

namespace UAMS2
{
    internal class BLDegreeProgram
    {
        public string DegreeTitle;
        public int Duration;
        public int Seats;

        public  List<BLSubject> SubjectsTaught =new List<BLSubject>();
        public BLDegreeProgram(string degreeTitle, int duration, int seats, List<BLSubject> subjects)
        {
            this.DegreeTitle = degreeTitle;
            this.Duration = duration;
            this.Seats = seats;
            SubjectsTaught = subjects;
        }
        public int getCreditHours()
        {
            int Count = 0;
            foreach (BLSubject i in SubjectsTaught)
            {
                Count += i.CreditHours;
            }
            return Count;
        }
        public bool isSubjectExists(BLSubject s)
        {
            foreach (BLSubject i in SubjectsTaught)
            {
                if (i.SubjectCode == s.SubjectCode)
                {
                    return true;
                }
            }
            return false;
        }
        public bool addSubject(BLSubject s)
        {
            int creditHours = getCreditHours();
            if (creditHours + s.CreditHours <= 20)
            {
                SubjectsTaught.Add(s);
                return true;
            }
            return false;
        }
      
        
    }
}
