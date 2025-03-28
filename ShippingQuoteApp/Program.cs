using System;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight (in pounds):");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            Console.WriteLine("Please enter the package width (in inches):");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height (in inches):");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length (in inches):");
            double length = Convert.ToDouble(Console.ReadLine());

            double dimensionTotal = width + height + length;

            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            double quote = (width * height * length * weight) / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
        }
    }
}
