using System;
using System.Collections.Generic;

namespace BridgeDataApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of bridge names
            string[] bridgeNames = { "Golden Gate", "Brooklyn", "Confederation", "Ambassador", "Capilano" };

            Console.WriteLine("Select an index (0–4) to view a bridge name:");
            int nameIndex = Convert.ToInt32(Console.ReadLine());
            bool validName = false;

            while (!validName)
            {
                try
                {
                    Console.WriteLine("Bridge name: " + bridgeNames[nameIndex]);
                    validName = true;
                }
                catch
                {
                    Console.WriteLine("Invalid index. Please enter a number between 0 and 4:");
                    nameIndex = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Array of bridge lengths (in meters)
            int[] bridgeLengths = { 2737, 1825, 12900, 2286, 140 };

            Console.WriteLine("\nSelect an index (0–4) to view bridge length:");
            int lengthIndex = Convert.ToInt32(Console.ReadLine());
            bool validLength = false;

            while (!validLength)
            {
                try
                {
                    Console.WriteLine("Bridge length: " + bridgeLengths[lengthIndex] + " meters");
                    validLength = true;
                }
                catch
                {
                    Console.WriteLine("Invalid index. Please enter a number between 0 and 4:");
                    lengthIndex = Convert.ToInt32(Console.ReadLine());
                }
            }

            // List of bridge types
            List<string> bridgeTypes = new List<string>()
            {
                "Suspension",
                "Suspension",
                "Beam",
                "Arch",
                "Suspension"
            };

            Console.WriteLine("\nSelect an index (0–4) to view bridge type:");
            int typeIndex = Convert.ToInt32(Console.ReadLine());
            bool validType = false;

            while (!validType)
            {
                try
                {
                    Console.WriteLine("Bridge type: " + bridgeTypes[typeIndex]);
                    validType = true;
                }
                catch
                {
                    Console.WriteLine("Invalid index. Please enter a number between 0 and 4:");
                    typeIndex = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThank you for using BridgeDataApp!");
            Console.ReadLine();
        }
    }
}
