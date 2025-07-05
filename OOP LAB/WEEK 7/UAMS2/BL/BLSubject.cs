using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS2
{
    internal class BLSubject
    {
        public string SubjectCode;
        public int CreditHours;
        public string SubjectType;
        public float SubjectFee;
        public BLSubject(string Code, int CH, string Type, float Fee) {
            this.SubjectCode = Code;
            this.CreditHours = CH;
            this.SubjectType = Type;
            this.SubjectFee = Fee;

        }
        
    }
}
