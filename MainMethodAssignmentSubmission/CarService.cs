using System;

namespace MaintenanceApp
{
    // This class will hold our method for processing a car service request
    public class CarService
    {
        // This void method takes two integers: mileage and serviceInterval
        public void ScheduleService(int mileage, int serviceInterval)
        {
            // Add the service interval to the current mileage to get next service point
            int nextService = mileage + serviceInterval;

            // Display when the next service is due
            Console.WriteLine("Next service is due at: " + nextService + " km");

            // Display the service interval value passed in
            Console.WriteLine("Service interval: " + serviceInterval + " km");
        }
    }
}
