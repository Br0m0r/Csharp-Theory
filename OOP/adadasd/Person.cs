using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adadasd
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Favecolor;

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        } 
    }
}
