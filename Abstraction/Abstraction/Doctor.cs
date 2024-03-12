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

        public Doctor(string first,string last,int number,string speciality) : base(first,last,number)
        {
            Speciality = speciality;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", " + Speciality;
        }
    }
}
