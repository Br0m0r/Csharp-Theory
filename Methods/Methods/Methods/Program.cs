
using System.Buffers.Text;
using System.ComponentModel;
using System.Transactions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Methods
{
    /*
Exercise 1: Greeting Method
-Create a method named Greet that takes a name as a parameter
 and prints out a greeting message to the console.


    public class Exercise1
    {
        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}");

        }

        static void Main()
        {
            Greet("Bromor");
            Greet("Lester");
            Greet("Xardas");

        }
        

    }

    
 Exercise 2: Add Two Numbers
-Define a method named Add that takes 
 two integers as parameters and returns their sum.
    

    public class Exercise2
    {
        public static int Add(int x,int y)
        {
            return x + y;
        }


        static void Main()
        {
            Console.WriteLine(Add(5, 6));


        }

    }
    

    Exercise 3: Calculate Area of a Circle
   -Write a method named CalculateArea that takes
    the radius of a circle as a parameter and returns the area.
    Use the formula area = π * r^2.
    

    public class Exercise3
    {
        public static double CalculateArea(double radius)
        {
            return Math.PI * (Math.Pow(radius,2));

        }

        static void Main()
        {
            Console.WriteLine(CalculateArea(10));
        }


    }

  Exercise 4: Reverse a String
  Write a method named ReverseString that takes a string 
  and returns a new string with the characters in reverse order.
    


    public class Exercise4
    {
        public static string ReverseString(string str)
        {
            
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main()
        {
            Console.WriteLine("Enter a string to reverse: ");
            string input = Console.ReadLine(); 

            string reversed = ReverseString(input); 
            Console.WriteLine(reversed); 
        }
    }
    
     
    Exercise 5: Check Even or Odd
    Write a method that takes an integer 
    and prints whether it is "Even" or "Odd".
    

    public class Exercise5
    {
        public static void OddEven(int number)
        {
            int result = number % 2;
            if (result == 0)
            {
                Console.WriteLine($"The number {number} is even");
            }
            else 
            {
                Console.WriteLine($"The number {number} is odd");
            }
        }

        static void Main()
        {
            OddEven(82573);
        }
    }


    Exercise: Temperature Converter
    Objective: Write a C# program that converts temperatures
    between Fahrenheit and Celsius.
    The program should prompt the user to choose the direction of conversion, 
    accept a temperature value, perform the conversion, 
    and display the result. Implement method overloading to
    handle both conversion directions.

    Requirements:
    Method Overloading: Implement two overloaded methods named ConvertTemperature:

    One method converts from Celsius to Fahrenheit.
    The other method converts from Fahrenheit to Celsius.
    User Input: Prompt the user first to choose the conversion direction:

    If the user inputs "C", they mean to convert from Celsius to Fahrenheit.
    If the user inputs "F", they mean to convert from Fahrenheit to Celsius.
    Perform Conversion: Based on the user's choice, ask for the temperature to convert, perform the conversion using the appropriate method, and display the result.

    Error Handling: Include basic error handling for user input.
    */


    public class Converter
    {
        public static double ConvertTemperature(double temp, string decides)
        {
            if (decides == "C")
            {
                return (temp - 32) * 5 / 9;
            }
            else // No need to check if decides == "F" again
            {
                return (temp * 9 / 5) + 32;
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter a value: ");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                string decides;
                do
                {
                    Console.WriteLine("Please define conversion type :\n Type 'C' to convert from Fahrenheit to Celsius\n" +
                        "Type 'F' to convert from Celsius to Fahrenheit");
                    decides = Console.ReadLine().ToUpper();

                    if (decides == "C" || decides == "F")
                    {
                        Console.WriteLine($"Your converted value is {ConvertTemperature(input, decides)}");
                        break; // Exit the loop after successful conversion
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try again.");
                    }
                } while (true); // Keep looping until a valid conversion is performed
            }
            else
            {
                Console.WriteLine("Invalid numerical input.");
            }
        }
    }
}