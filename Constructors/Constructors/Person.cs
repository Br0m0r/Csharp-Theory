using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Person
    {
        private readonly string firstName;
        private readonly string lastName;


        public Person(string first,string last)
        {
            firstName = first;
            lastName = last;
        }

        public string GetFullName()
        {
            
            return firstName + " " + lastName;
        }
    }
}
