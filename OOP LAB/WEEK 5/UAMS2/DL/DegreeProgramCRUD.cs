using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS2.UL;

namespace UAMS2
{
    internal class DegreeProgramCRUD
    {
       public static List<BLDegreeProgram> degreesList= new List<BLDegreeProgram>();
        public void AddDegree()
        {
            degreesList.Add(ULDegree.AddDegree());
        }
        public void ViewDegreePrograms()
        {
            foreach (BLDegreeProgram d in degreesList)
            {
                Console.WriteLine(d.DegreeTitle);
            }
        }
    }
}
