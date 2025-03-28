using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to multiply by 50:");
            long input1 = Convert.ToInt64(Console.ReadLine());
            long result1 = input1 * 50;
            Console.WriteLine("Result: " + result1);

            Console.WriteLine("Enter a number to add 25:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int result2 = input2 + 25;
            Console.WriteLine("Result: " + result2);

            Console.WriteLine("Enter a number to divide by 12.5:");
            double input3 = Convert.ToDouble(Console.ReadLine());
            double result3 = input3 / 12.5;
            Console.WriteLine("Result: " + result3);

            Console.WriteLine("Enter a number to check if greater than 50:");
            int input4 = Convert.ToInt32(Console.ReadLine());
            bool isGreater = input4 > 50;
            Console.WriteLine("Is the number greater than 50? " + isGreater);

            Console.WriteLine("Enter a number to divide by 7 and get the remainder:");
            int input5 = Convert.ToInt32(Console.ReadLine());
            int remainder = input5 % 7;
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
