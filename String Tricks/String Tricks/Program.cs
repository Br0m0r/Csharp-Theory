namespace StringTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Bromor";
            string LastName = "Plays";
            int age = 99;

            //concatenation
            string ConcatString = "Description: "+FirstName + " " + LastName + " " + age;

            //Console.WriteLine(ConcatString);

            //escaping characters(\)
            string quote = "He said: \"something\"";//escape sequence for double quotes INtext
            Console.WriteLine(quote);

            string path = "C:\\SomeFolder\\SomeFile.txt"; //double backslash for  file path
            Console.WriteLine(path);

            string networkPath = "\\\\Computer\\Somefolder\\Somefile.txt";
            Console.WriteLine(networkPath);

            string newLine = "This is Line 1.\n\tThis is Line 2.\nThis is Line 3";  // \n for new line , \t for tab
            Console.WriteLine(newLine);

            //verbatim string literals
            string literal = @"\\computer\someFolder\someFile.txt quote: ""asdasd"" "; //havent seen this one used except for file paths
            Console.WriteLine(literal);

            //string interpolation
            string interpolated = $"Description: {FirstName} {LastName},{age}";
            Console.WriteLine(interpolated);

            


        }
    }
}