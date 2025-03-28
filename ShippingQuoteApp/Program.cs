using System;
namespace ShippingQuoteApp 
    class Program
    {
        static void Main(string[] args)
        {
            // Greet the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask for the weight of the package in pounds
            Console.WriteLine("Please enter the package weight (in pounds):");
            double weight = Convert.ToDouble(Console.ReadLine()); // Convert the input to a number

            // If the package is too heavy, show an error message and stop the program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Ask for the width in inches
            Console.WriteLine("Please enter the package width (in inches):");
            double width = Convert.ToDouble(Console.ReadLine());

            // Ask for the height in inches
            Console.WriteLine("Please enter the package height (in inches):");
            double height = Convert.ToDouble(Console.ReadLine());

            // Ask for the length in inches
            Console.WriteLine("Please enter the package length (in inches):");
            double length = Convert.ToDouble(Console.ReadLine());

            // Add up all the dimensions
            double dimensionTotal = width + height + length;

            // If the total size is too big, show an error message and stop
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate the shipping quote based on the size and weight
            double quote = (width * height * length * weight) / 100;

            // Show the user the final price, formatted as currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
        }
    }
}
