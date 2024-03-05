using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Person
    {
        public Person(string first,string last)
        { 
            FirstName = first;
            LastName = last;
        }
        //auto property
        public string FirstName { get; private set; } //this automatically compiles the get set procedure below
        /*Property
        public string FirstName
        {
            get { return firstName; }
            set
            {
                FirstName = value;
                //updateUI(value);
            }
        }
        private string firstName;
        */
        public string LastName { get; private set; }
        public int Age { get; set; }
    }
}
