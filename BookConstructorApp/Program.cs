using System;

namespace BookConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a constant string message
            const string message = "Enter book title or price: ";

            // Show message to the user
            Console.WriteLine(message);

            // Create a variable using the 'var' keyword
            var input = Console.ReadLine();

            // Try to parse input as a float
            if (float.TryParse(input, out float price))
            {
                // If it's a number, create a Book object with the price
                Book b1 = new Book(price);
            }
            else
            {
                // If it's not a number, create a Book object with the title
                Book b2 = new Book(input);
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
