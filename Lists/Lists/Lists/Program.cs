using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System;
using System.Globalization;
using System.Collections;
using System.Reflection;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System.Numerics;
using System.Diagnostics.CodeAnalysis;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;

namespace Exercises
{
    /*
Exercise 1: Basic List Operations

 Create a program that:
-Creates a list of integers.
-Adds five numbers to the list.
-Removes the second number.
-Inserts a new number at the start.
-Prints each number in the list to the console.
    
    public class Exercise1
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                numbers.Add(i+1);
                Console.WriteLine($"added number {i+1} at Index : {i}");              
                    
            }
            numbers.RemoveAt(1);
            int index = numbers.IndexOf(1);
            Console.WriteLine(index);
            numbers.Insert(0, 4);
            Console.WriteLine($"Inserted 4 at index {0}");

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }



        }
    }

    */



    /*
    Exercise 2: Searching and Sorting

     Create a program that:
    -Creates a list of integers and populates it with random numbers.
    -Searches for a specific number in the list and prints its index.
     If not found, print a message.
    -Sorts the list in ascending order and prints the sorted list.


        public class Exercis2
        {

            static void Main()
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < 10; i++)
                {
                    numbers.Add(i + 1);
                    Console.WriteLine($"added number {i + 1} at Index : {i}");
                    Console.WriteLine();

                }
                Random random = new Random();

                Console.WriteLine("Generating a random number between 0 - 20...\n");
                int r = random.Next(0, 20);
                    bool n = numbers.Contains(r);

                    if (n)
                    {
                      Console.WriteLine($"Here is your number: {r} at index {numbers.IndexOf(r)}\n");

                    }
                    else
                    {
                      Console.WriteLine($"The number {r} is not included in the list");
                    }
                    numbers.Sort();
                    foreach (int i in numbers)
                    {
                      Console.WriteLine(i);

                    }



            }

        }

        */
    /*
    Exercise 3: Modifying List Elements

    Create a program that:
    -Creates a list of strings, representing a list of fruits.
    -Asks the user to enter the name of a fruit, then adds it to the list.
    -Asks the user to enter a fruit to remove from the list.
     If the fruit exists, remove it; otherwise, print a message.
    -Prints the final list of fruits.


        public class Exercise3
        {
            static void Main()
            {
                List<string> fruits = new List<string>();
                fruits.Add("banana");
                fruits.Add("apple");
                fruits.Add("grapes");
                fruits.Add("pear");
                Console.WriteLine("Please enter a fruit to add : ");
                fruits.Add(Console.ReadLine());
                Console.WriteLine("Please enter a fruit to remove: ");
                string fruitToRemove = Console.ReadLine();

                string foundFruit = fruits.FirstOrDefault(fruit => fruit.Equals(fruitToRemove, StringComparison.OrdinalIgnoreCase));
                if (foundFruit != null)
                {
                    fruits.Remove(foundFruit);
                    Console.WriteLine($"{foundFruit} has been removed.");
                }
                else
                {
                    Console.WriteLine("The fruit is not on the list.");
                }

                foreach (string i in fruits)
                {
                    Console.WriteLine(i);
                    Console.WriteLine();
                }





            }



        }

        /* BIG NOTE 
         * The String.Equals method and the StringComparison.OrdinalIgnoreCase 
         * enumeration in C# play crucial roles in string comparison, 
         * especially when you need to compare strings in a case-insensitive manner. 
         * Let's break down each component for a better understanding:
         * 
         * String.Equals Method
           The String.Equals method is used to compare two strings to determine
           if they are equal. It can be used in several ways, but one common usage 
           is to specify how the comparison should be conducted, particularly regarding 
           case sensitivity. The method signature that is often used for case-insensitive
           comparisons looks like this:
        */
    //  public static bool Equals (string a, string b, StringComparison comparisonType);
    /*
     * a and b: These are the strings you want to compare.
       comparisonType: This parameter determines how the comparison is performed,
       allowing you to specify case sensitivity and culture-specific rules.

    StringComparison.OrdinalIgnoreCase :

    StringComparison is an enumeration that specifies the rules for comparing strings. 
    StringComparison.OrdinalIgnoreCase is a member of this enumeration used to indicate
    that a string comparison should be case-insensitive and not culture-specific. 
    This means that the comparison treats uppercase and lowercase letters as being equal
    without considering any culture-specific rules that might affect the comparison 
    order.

    Case-Insensitive: Uppercase and lowercase versions of letters are considered equal.
    For example, "apple" equals "Apple".

    Ordinal: The comparison is based on the numeric value (Unicode code points) 
    of each character in the strings, making it a fast and culture-independent comparison.
    



Exercise 4: List Statistics
Create a program that:

- Creates a list of integers and populates it with random numbers.
- Calculates and prints the sum, average, maximum, and minimum values
  of the numbers in the list.
    
    
    public class Exercise4
    {
         
        public static void Main()
        {
            int sum = 0;
            int avrg = 0;
            int max = 0;
            int min = 0;
            List<int> numbers = new List<int>();
            Random random = new Random();
            for (int i = 0;i < 11;i++)
            {
                int r = random.Next(0, 50);
                numbers.Add(r);
                Console.WriteLine($"Inserted number {r} at index{i}");
                Console.WriteLine();
            }
            Console.WriteLine("Choose your preference of calculation to be done :");
            Console.WriteLine();
            Console.WriteLine("Valid inputs :\nSUM\nAVRG\nMAX\nMIN");
            string calc = Console.ReadLine();
            if (string.IsNullOrEmpty(calc))
                {
                Console.WriteLine("Please enter a valid input");
                }
            else
            {
                switch (calc.ToUpper())
                {
                    case "SUM" :
                        foreach (int i in numbers)
                        {
                            sum += i;
                        }
                        Console.WriteLine($"Your sum is : {sum}");
                        break;

                    case "AVRG":
                        foreach (int i in numbers)
                        {
                            sum += i;
                        }
                        avrg = sum / (numbers.Count);
                        Console.WriteLine($"Your average is: {avrg}");
                        break;

                    case "MAX":
                        foreach (int i in numbers)
                        {
                            if (i > max)
                            {
                                max = i;
                            }
                            else continue;
                        }
                        Console.WriteLine($"Your maximum is {max}");
                        break;

                    case "MIN":
                        min = numbers[0];
                        foreach(int i in numbers)
                        {
                            if (i < min)
                            {
                                min = i;
                            }
                            else continue;
                        }
                        Console.WriteLine($"Your minimum is {min}");
                        break;

                }
            }
            

        }
    }

    
   Exercise: List Manipulation and Search
   Objective: Write a program that performs various operations on a list of names. 
   The program should allow adding names to the list, removing names,
   searching for a name to see if it's present, and printing all names 
   in alphabetical order.

 Requirements:

 - Start with an empty list of strings to store names.

 - Add names to the list until the user decides to stop.

 - Ask the user for a name to remove from the list. 
   Inform the user whether the removal was successful or not.

 - Allow the user to search for a name in the list, and indicate whether or not it exists.

 - Print all names in the list in alphabetical order.
    */

    class Program
    {
        static void Main()
        {
            List<string> names = new List<string>();

            
            string input = "";
            while (true)
            {
                Console.WriteLine("Enter a name to add (or type 'done' to finish adding):");
                input = Console.ReadLine();
                if (input.ToLower() == "done")
                {
                    break;
                }
                names.Add(input);
            }

            
            Console.WriteLine("Enter a name to remove:");
            input = Console.ReadLine();
            if (names.Remove(input))
            {
                Console.WriteLine($"{input} was removed.");
            }
            else
            {
                Console.WriteLine($"{input} was not found in the list.");
            }

            
            Console.WriteLine("Enter a name to search for:");
            input = Console.ReadLine();
            if (names.Contains(input))
            {
                Console.WriteLine($"{input} exists in the list.");
            }
            else
            {
                Console.WriteLine($"{input} does not exist in the list.");
            }

            
            names.Sort();
            Console.WriteLine("Names in alphabetical order:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }







}