// Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate first Employee object
        Employee emp1 = new Employee() { Id = 101, FirstName = "John", LastName = "Smith" };

        // Instantiate second Employee object
        Employee emp2 = new Employee() { Id = 101, FirstName = "Jane", LastName = "Doe" };

        // Compare both Employee objects using overloaded ==
        bool areEqual = emp1 == emp2;

        // Output result
        Console.WriteLine("Are the two employees equal? " + areEqual);

        // Hold console open
        Console.ReadLine();
    }
}