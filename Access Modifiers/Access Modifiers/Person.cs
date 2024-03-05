using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    /*
     * Access modifiers:where the item (class,method,field,etc) can be used
     * Enables ENCAPSULATION  (OOP concept)
     * - Keeping data together with its relevant methods
     * - Restricting direct access to this data to keep things simple and safe from unwanted modifications
     * --------------------------------------------
     * Public:can be used in any class
     * Private:Can only be used in the class it is in
     * --------------------------------------------
     * Protected: Can only be used in the class it is in or classes derived from it
     *            Very similar to private,except used with inheritance(OOP concept)
     *            -class dog,and that class dog inherits from clas animal
     * Internal : Can be used in any class in the current assembly
     *           - same as public but for only one project
     * Protected internal: Can be used in any class in the current assembly or classes in other assemblies derived from the class it is in
     * Private protected : Can only be used in the class it is in or classes derived from it in the current assembly
     * */
        internal class Person
    {
        private string firstname;
        private string lastname;
        private int age;

        public void SetFirstName(string name)
        {
            firstname = name;
        }
        public void SetLastName(string name)
        {
            lastname = name;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge() 
        {
            return age;
        }

        public string GetFullName()
        {
            return firstname + " " + lastname;
        }

        public string GetDescription()
        {
            string descriptionBase = "Description";
            string description = BuildDescription();
            return descriptionBase + " " + description;
        }

        private string BuildDescription()
        {
            return  firstname + " " + lastname + " " + age;
        }
    }
}
