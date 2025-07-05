using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonStaff
{
    internal class Student:Person
    {
        private string Program;
        private int Year;
        private double Fee;
        public Student(string name, string address, string Program, int Year, double fee) : base(name, address)
        {
            SetProgram(Program);
            SetYear(Year);
            SetFee(Fee);
           
        }
        public string GetProgram()
        { return Program; }
        public void SetProgram(string program)
        {
            this.Program=program;
        }
        public int GetYear()
        {
            return this.Year;
        }
        public void SetYear(int year)
        {
            this.Year=year;
        }
        public void SetFee(double fee)
        {
            this.Fee=fee;
        }
    }
}
