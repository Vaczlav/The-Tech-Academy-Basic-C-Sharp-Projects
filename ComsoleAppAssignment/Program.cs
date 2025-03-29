//Assignment Part 1
//Intro: Informing the user what this console app does
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Bridge Description App ===");
        Console.WriteLine("This program adds your custom description to a list of bridge names.");
        Console.WriteLine("You will be asked to enter a short phrase or word to describe all bridges.\n");

        //Creating a one-dimensional array of strings representing bridge names:
        string[] bridges = { "Golden Gate", "Brooklyn", "Tower", "Confederation", "Lions Gate" };

        //Asking the user for text input to append to each bridge name:
        Console.Write("Enter a description to add to each bridge name (e.g., 'is iconic'): ");
        string userInput = Console.ReadLine();

        //Looping through each element in the array and appending the user input:
        for (int i = 0; i < bridges.Length; i++)
        {
            bridges[i] = bridges[i] + " " + userInput;
        }

        //Looping through the updated array and printing each bridge name with the added text:
        Console.WriteLine("\nUpdated list of bridges:");
        foreach (string bridge in bridges)
        {
            Console.WriteLine(bridge);
        }

        //End of Assignment Part 1

        //Assignment Part 2
        //Originally created an infinite loop using: while (true)
        //To fix the infinite loop, we replaced it with a for loop using the '<' operator
        //Now the loop runs up to 5 times, but the user can still exit early by typing 'exit'

        Console.WriteLine("\n=== Loop Section: You can type up to 5 times (or type 'exit' to stop early) ===");

        for (int i = 0; i < 5; i++) // Replacing the infinite loop with '<' based loop
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting loop early. Goodbye!");
                break; // Breaks out of the loop if user types 'exit'
            }
            else
            {
                Console.WriteLine("You typed: " + input);
            }
        }
        //End of Assignment Part 2

        //Assignment Part 3
        //Creating a loop that uses the '<' comparison operator
        Console.WriteLine("\nLoop using '<' operator:");
        for (int i = 0; i < 3; i++) // Will execute while i is less than 3
        {
            Console.WriteLine("i is less than 3: " + i);
        }

        //Creating a loop that uses the '<=' comparison operator
        Console.WriteLine("\nLoop using '<=' operator:");
        for (int i = 0; i <= 3; i++) // Will execute while i is less than or equal to 3
        {
            Console.WriteLine("i is less than or equal to 3: " + i);
        }
        //End of Assignment Part 3

        //Assignment Part 4
        //This part adds a searchable list of bridge types to our bridge-themed console app.
        Console.WriteLine("\n=== Bridge Type Search App ===");

        //Creating a new list of bridge types
        List<string> bridgeTypes = new List<string> { "Suspension", "Arch", "Beam", "Cable-Stayed", "Truss" };

        //Description for user
        Console.WriteLine("You can search for one of the following bridge types: Suspension, Arch, Beam, Cable-Stayed, Truss");
        Console.Write("Enter a bridge type or keyword to search: ");
        string userSearch = Console.ReadLine();

        //Flag to track if a match was found
        bool matchFound = false;

        //Loop through the list to search for a match
        for (int i = 0; i < bridgeTypes.Count; i++)
        {
            if (bridgeTypes[i].ToLower().Contains(userSearch.ToLower()))
            {
                Console.WriteLine($"Match found at index {i}: {bridgeTypes[i]}");
                matchFound = true;
                break; // Stop the loop once a match is found
            }
        }

        //If no match is found, notify the user
        if (!matchFound)
        {
            Console.WriteLine("No match found. Your input is not on the list.");
        }
        //End of Assignment Part 4

        //Assignment Part 5
        //This part searches a list with duplicates and returns all matching indices.
        Console.WriteLine("\n=== Bridge Name Multi-Match Search ===");

        //Creating a list of bridge names with duplicates
        List<string> duplicateBridges = new List<string> { "Brooklyn", "Tower", "Golden Gate", "Tower", "Brooklyn" };

        //Ask user for search term
        Console.Write("Enter a bridge name to find all matches: ");
        string searchInput = Console.ReadLine();

        //Track if any matches were found
        bool anyMatches = false;

        //Iterate through list and show all matching indices
        for (int i = 0; i < duplicateBridges.Count; i++)
        {
            if (duplicateBridges[i].ToLower().Contains(searchInput.ToLower()))
            {
                Console.WriteLine($"Match found at index {i}: {duplicateBridges[i]}");
                anyMatches = true;
            }
        }

        //Notify if no matches found
        if (!anyMatches)
        {
            Console.WriteLine("No matches found. Your input is not on the list.");
        }
        //End of Assignment Part 5
    }
}