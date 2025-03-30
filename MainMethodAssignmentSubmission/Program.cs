using System;

namespace MaintenanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the CarService class
            CarService myService = new CarService();

            // Call the method using regular argument order
            myService.ScheduleService(40000, 10000);

            // Call the method using named parameters
            myService.ScheduleService(serviceInterval: 12000, mileage: 53000);

            // Pause the console so user can read results
            Console.ReadLine();
        }
    }
}
