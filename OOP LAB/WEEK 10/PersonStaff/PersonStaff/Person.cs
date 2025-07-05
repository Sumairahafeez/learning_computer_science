using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonStaff
{
    internal class Person
    {
        private string name;
        private string address;
        public Person(string name, string address)
        {
            SetName(name);
            SetAddress(address);
           
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public string ToString()
        {
            return "Person[name: "+name+" address: "+address+"]";
        }
    }
}
