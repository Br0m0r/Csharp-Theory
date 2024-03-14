namespace Interfaces___FromScratch__
{

    class Program
    {

        static void Main(string[] args)
        {
            //Foreach thing that CAN move
            //thing.Move();

            Dog dog = new Dog();
            Boat boat = new Boat();

            List<Imove> moveableEntities = new List<Imove>() { dog, boat };
            
            foreach (var entity in moveableEntities)
            {
                entity.Move();
            }

            List<ImakeSound> soundables = new List<ImakeSound>() { dog, boat };

            foreach (var entity in soundables)
            {
                entity.MakeSound();
            }


            Console.WriteLine();
        }
    }



}
