using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating and initializing the Employee object
            Employee emp = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 123
            };

            // Calling SayName() method (inherited from Person)
            emp.SayName();

            // Keep console window open
            Console.ReadLine();
        }
    }
}
