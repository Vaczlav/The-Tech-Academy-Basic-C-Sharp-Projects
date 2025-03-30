using System;

namespace CarPricing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro message
            Console.WriteLine("=== Welcome to the Honda CR-V Pricing Calculator ===");

            //Step 1: Select Trim
            Console.WriteLine("\nSelect your trim level:");
            Console.WriteLine("1 - Base ($32,000)");
            Console.WriteLine("2 - EX ($36,000)");
            Console.WriteLine("3 - Touring ($40,000)");
            Console.Write("Enter trim level (1-3): ");
            int trim = Convert.ToInt32(Console.ReadLine());

            //Step 2: Select Features Package
            Console.WriteLine("\nSelect a features package for your trim:");
            Console.WriteLine("1 - Basic Package: Tinted windows, cloth seats, standard color (+$0)");
            Console.WriteLine("2 - Mid Package: Sunroof, leather seats, metallic paint (+$2,500)");
            Console.WriteLine("3 - Premium Package: Sunroof, leather seats, premium audio, navigation system (+$5,000)");
            Console.Write("Enter your package choice (1-3): ");
            int package = Convert.ToInt32(Console.ReadLine());

            //Calculating final price
            int basePrice = CarCostCalculator.BasePrice(trim);
            int packagePrice = CarCostCalculator.PackagePrice(package);
            int subtotal = basePrice + packagePrice;
            int totalPrice = CarCostCalculator.AddTax(subtotal);

            //Display results
            Console.WriteLine("\n--- Pricing Summary ---");
            Console.WriteLine($"Trim Price: ${basePrice}");
            Console.WriteLine($"Package Price: ${packagePrice}");
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Total with Tax (13%): ${totalPrice}");
            Console.WriteLine("\nThank you for using the CR-V pricing calculator!");
        }
    }
}
