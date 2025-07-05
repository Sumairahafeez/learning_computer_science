using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS2
{
    internal class StudentCRUD
    {
        public  List<BLStudent> studentList = new List<BLStudent>();
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
    }
}
