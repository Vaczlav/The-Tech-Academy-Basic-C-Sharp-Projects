using System;

// Main class to demonstrate polymorphism using interfaces
class Program
{
    static void Main(string[] args)
    {
        // Create a new Employee and assign properties
        Employee emp = new Employee()
        {
            FirstName = "John",
            LastName = "Doe",
            Id = 101
        };

        // Use polymorphism: store Employee as IQuittable
        IQuittable quitter = emp;

        // Call Quit method via interface
        quitter.Quit();

        // Optional: call SayName to show it's still an Employee
        emp.SayName();
    }
}