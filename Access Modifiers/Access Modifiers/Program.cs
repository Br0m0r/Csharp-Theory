using Access_Modifiers;

namespace AccessMod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetFirstName("bromor");
            person.SetLastName("Plays");

            person.SetAge(99);
           

            Console.WriteLine(person.GetDescription());

            Console.ReadLine();
        }



    }
}