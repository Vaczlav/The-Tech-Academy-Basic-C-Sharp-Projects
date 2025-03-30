using System;

namespace CarMaintenanceApp
{
    class Program
    {
        // Define an enum for days of the week
        public enum CarMaintenanceDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Enter the current day of the week (e.g., Monday):");
                string input = Console.ReadLine().Trim(); // Remove leading/trailing spaces

                // Try parsing ignoring case sensitivity
                if (Enum.TryParse(input, ignoreCase: true, out CarMaintenanceDay day))
                {
                    Console.WriteLine("Your car can be serviced on: " + day);
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week (e.g., Monday).");
                }
            }
        }
    }
}