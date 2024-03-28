namespace UseofRandom
{
    class Program
    {
        static void Main()
        {
            //C#'s random class provide pseudo random number generation
            Random random = new Random();

            //random int
            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            //random int between 0  and x
            int randomInt2 = random.Next(101); // 0 - 100
            Console.WriteLine(randomInt2);

            //random int between x and y
            int randomInt3 = random.Next(1, 11); // 1-10  minimum value is inclusive,max is not
            Console.WriteLine(randomInt3);

            //random double
            double randomD = random.NextDouble(); // 0-1    takes no overloads(there are ways around this,eg multiply this random number by something)
            Console.WriteLine(randomD);

            string[] names = { "Bob", "Jim", "George", "Mary", "Katy" };
            int randomIndex = random.Next(names.Length);
            Console.WriteLine(names[randomIndex]);



            //Generate  100 coin flips and see results
            int heads = 0;
            int tails = 0;

            for (int i = 0; i < 100; i++)
            {
                int coinFlip = random.Next(2); //0 - 1 (for heads and tails)
                if (coinFlip == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine($"Heads:{heads}\nTails:{tails}");

        }
    }
}