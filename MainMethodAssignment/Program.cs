using System;

namespace MathOverloadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instance of EventMath class
            EventMath eventMath = new EventMath();

            // Call method with int parameter
            int withInt = eventMath.GuestsCount(25); // 25 + 10
            Console.WriteLine("Estimated total with int: " + withInt);

            // Call method with decimal parameter
            int withDecimal = eventMath.GuestsCount(32.5m); // 32.5 * 50.5
            Console.WriteLine("Cost with decimal input: $" + withDecimal);

            // Call method with string parameter
            int withString = eventMath.GuestsCount("40"); // 40 - 5
            Console.WriteLine("Adjusted count with string input: " + withString);
        }
    }
}
