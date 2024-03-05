/*namespace begginerTutorialDebugging
{
    internal class Program
    {
        static List<string> names = new List<string>() { "Adam", "Bob", "George", "franceska", "Lisa" };
        //step in:we keep going deeper and deeper in the code
        //step over: we are staying at the same level in the code
        //step out we want to go back to the previous level

        static void Main(string[] args)
        {
            //int currentListNumber;
            for (int i = 0; i<names.Count;i++)
            {
                //currentListNumber = i + 1;
                i = i + 1; //this creates the problem
                PrintNumberedName(i, names[i]);
            }
            Console.ReadLine();
        }

        static void PrintNumberedName(int number,string name)
        {
            Console.WriteLine(number + " " + name);
        }
    }
}
*/

using adadasd;

namespace OOP
{
    internal class Program
    {
        /*
         *OOP is a programing paradigm  based on he concept of objects,can contain data and methods 
         */
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
           // List<string> FirstNames = new List<string>();
           // List<string> LastNames = new List<string>();
           // List<int> ages = new List<int>();

            while (true)
            {
                Console.Write("Enter your first name: ");
                string firstNameInput = Console.ReadLine();

                if (firstNameInput == "done")
                {
                    Console.Clear();
                    break;
                }

                Console.Write("Enter your last name: ");
                string lastNameInput = Console.ReadLine();
                Console.Write("Enter your age: ");
                int ageInput = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter your fave color: ");
                string  ColorInput = Console.ReadLine();

                Person person = new Person();
                person.FirstName = firstNameInput;
                person.LastName = lastNameInput;
                person.Age = ageInput;
                person.Favecolor = ColorInput;

                people.Add(person);

                //or another way 
                /*

                Person person1 = new Person
                {
                    FirstName = firstNameInput,
                    LastName = lastNameInput,
                    Age = ageInput
                    
                };
                */

              // FirstNames.Add(firstNameInput);
              //  LastNames.Add(lastNameInput);
              //  ages.Add(ageInput);

                Console.Clear();
            }

            //Where we would do our databse logic
            foreach (Person person in people) 
            {

                //write person to database(then the database layer would handle anything else)
                // string FullName = person.FirstName + " " + person.LastName;
                string Fullname = person.GetFullName();
                
            }

        }
    }
}