//Assignment: List Division with Error Handling
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Step 1: Create a list of integers
        List<int> numbers = new List<int> { 10, 25, 50, 100, 200 };

        //Step 2: Declare a flag to track if valid input has been entered
        bool validInput = false;

        //Step 3: Loop until valid input is received
        while (!validInput)
        {
            try
            {
                //Prompt user for input
                Console.Write("Enter a number to divide each value in the list by: ");
                string input = Console.ReadLine();

                //Try to convert input to a number
                float divisor = float.Parse(input);

                //Check if the user entered zero
                if (divisor == 0)
                {
                    Console.WriteLine("Cannot divide by zero. Please enter a non-zero number.");
                }
                else
                {
                    //Loop through the list and divide each item
                    Console.WriteLine("\nResults:");
                    foreach (int number in numbers)
                    {
                        float result = number / divisor;
                        Console.WriteLine($"{number} / {divisor} = {result}");
                    }

                    //Mark input as valid so we can exit the loop
                    validInput = true;
                }
            }
            catch (FormatException)
            {
                //Catch invalid format (e.g., string input)
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

        //Step 4: Code that runs after try/catch block
        Console.WriteLine("\nProgram has completed the try/catch block and continues execution.");
    }
}
