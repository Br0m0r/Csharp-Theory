using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //derived class (child) AND base class (parent)
    internal class Employee : Person
    {
        public int EmployeeNumber { get; set; }

        public override string GetDescription()
        {
            return GetFullName() + ", " + EmployeeNumber;
        }
    }
}
