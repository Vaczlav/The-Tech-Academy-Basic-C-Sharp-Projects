using System;

namespace BookConstructorApp
{
    public class Book
    {
        // Constructor if only the title is provided
        public Book(string title) : this(title, 0.0f)
        {
            Console.WriteLine("Only title provided, default price is $" + Price);
        }

        // Constructor if only the price is provided
        public Book(float price) : this("Unknown", price)
        {
            Console.WriteLine("Only price provided, default title is " + Title);
        }

        // Constructor when both title and price are provided
        public Book(string title, float price)
        {
            Title = title;
            Price = price;
        }

        // Properties to store the title and price
        public string Title { get; set; }
        public float Price { get; set; }
    }
}
