namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter a nunber");

                string input = Console.ReadLine();

                int number = 0;
                //try
                //{
                //     number = Convert.ToInt32(input);
                //     Console.WriteLine($"You entered {number}");
                //}
                //catch(FormatException ex1)
                //{
                //    Console.WriteLine($"Error: {ex1.Message} ");
                //    Console.WriteLine("You must enter a valid number");//this is catching a format exception(it wont catch overflow exception
                //                                                              //eg if we insert a long type of number to int above)
                //}
                //catch (OverflowException)
                //{
                //    Console.WriteLine("Error: Your number is too big");
                //}
                //catch(Exception ex)//catching generic exceptions,i can add variable name that will save to the exception object
                //{
                //    Console.WriteLine($"Error: {ex.Message} ");//this will print the message that was thrown so we can get more info regarding our exception error
                //}
                //finally //this runs in the end of try-catch no matter what happens
                //{
                //    Console.WriteLine();
                //}


                //we can also do this in a nested if else statement:

                try
                {
                    number = Convert.ToInt32(input);
                    Console.WriteLine($"You entered {number}");
                }
                catch (Exception ex)//catching generic exceptions,i can add variable name that will save to the exception object
                {
                    if (ex is FormatException)
                    {
                        Console.WriteLine("Error!You must enter a number");
                    }
                    else if (ex is OverflowException)
                    {
                        Console.WriteLine("Error!Your number is too big(noice)");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {ex.Message} ");//this will print the message that was thrown so we can get more info regarding our exception error
                    }
                    
                }
                finally //this runs in thke end of try-catch no matter what happens
                {
                    Console.WriteLine();
                }




            }
        }
    }
}