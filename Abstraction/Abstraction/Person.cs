using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // abstraction  - OOP concept
    // hide away certain logic,expose only  what we need at any given level
    // you cant create an object of an abstract class
    //base class (Parent)
    abstract internal class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public abstract string GetDescription();
       

        
        
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
