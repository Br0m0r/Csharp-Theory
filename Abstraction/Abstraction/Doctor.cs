using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Doctor : Employee
    {
        public string Speciality {  get; set; }

        public override string GetDescription()
        {
            return GetFullName() + ", " + EmployeeNumber + ", " + Speciality;
        }
    }
}
