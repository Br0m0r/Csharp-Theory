using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    
    internal class Employee : IPerson
    {
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Employee(string first,string last,int number) 
        {
            FirstName = first;
            LastName = last;
            EmployeeNumber = number;

        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public  string GetDescription()
        {
            return GetFullName() + ", " + EmployeeNumber;
        }
    }
}
