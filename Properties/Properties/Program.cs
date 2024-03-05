namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person person = new Person();
            person.FirstName = "Bromor";
            person.LastName = "Plays";
            OR  we can do : */
            Person person = new Person("Bromor","Plays")
            {                
                Age = 55
            };

            //if we want to get the information :
            int age = person.Age;
            //if we want to change it :
            
        }
    }
}