namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter an even nunber between 2 and 10");

                string input = Console.ReadLine();
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


                //we can also and should do this in a nested if else statement:

                try
                {
                   // MyMethod();
                    int number = Convert.ToInt32(input);
                    ValidateInput(number);
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
                    else if (ex is ArgumentOutOfRangeException || ex is ArgumentException)
                    {
                        Console.WriteLine("Error!Your number must be an even number between 2 and 10");
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
        private static void ValidateInput(int number)
        {
             // make sure input is even
             if (number % 2 != 0) // we can also instead check all of the arguments at once here
                // E.G it would be : if (number % 2 != 0 || number < 2 || number > 10),
                //in which case we would have only one Argument Exception
            {
                //not even
                //throw new Exception("Invalid input: enter even number");
                throw new ArgumentException();
            }
             if (number < 2 || number > 10)
            {
                throw new ArgumentOutOfRangeException();
            }
             //in this case,we have to be carefull which one of the 2 exceptions we want to check for
             //E.G. if we put 12 we will get Out of range Ex,but if we put 11, we will get the Ex for even number
        }


        //private static void MyMethod()  //we can have this generated to make sure we remember to implement the body of the method
        //{
        //    throw new NotImplementedException();
        //}
    }
}