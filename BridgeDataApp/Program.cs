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

            // Ask user to select an index for bridge name
            Console.WriteLine("Enter an index (0–4) to view a bridge name:");
            int nameIndex = Convert.ToInt32(Console.ReadLine());

            if (nameIndex >= 0 && nameIndex < bridgeNames.Length)
            {
                Console.WriteLine("Bridge name: " + bridgeNames[nameIndex]);
            }
            else
            {
                Console.WriteLine("That index does not exist in the bridge names array.");
            }

            // Array of bridge lengths in meters
            int[] bridgeLengths = { 2737, 1825, 12900, 2286, 140 };

            Console.WriteLine("Enter an index (0–4) to view the length of a bridge (in meters):");
            int lengthIndex = Convert.ToInt32(Console.ReadLine());

            if (lengthIndex >= 0 && lengthIndex < bridgeLengths.Length)
            {
                Console.WriteLine("Bridge length: " + bridgeLengths[lengthIndex] + " meters");
            }
            else
            {
                Console.WriteLine("That index does not exist in the bridge lengths array.");
            }

            // List of bridge structure types
            List<string> bridgeTypes = new List<string> { "Suspension", "Cable-stayed", "Arch", "Beam", "Truss" };

            Console.WriteLine("Enter an index (0–4) to view the bridge structure type:");
            int typeIndex = Convert.ToInt32(Console.ReadLine());

            if (typeIndex >= 0 && typeIndex < bridgeTypes.Count)
            {
                Console.WriteLine("Bridge type: " + bridgeTypes[typeIndex]);
            }
            else
            {
                Console.WriteLine("That index does not exist in the bridge types list.");
            }

            // Hold the console window open
            Console.ReadLine();
        }
    }
}
