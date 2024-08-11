using DictionaryExample;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        AgeDictionaryManager ageManager = new AgeDictionaryManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add/Update an entry");
            Console.WriteLine("2. Search for an entry");
            Console.WriteLine("3. Remove an entry");
            Console.WriteLine("4. Display all entries");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the name: ");
                    string nameToAdd = Console.ReadLine();
                    Console.Write("Enter the age: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        ageManager.AddAge(nameToAdd, age);
                    }
                    else
                    {
                        Console.WriteLine("Invalid age. Please enter a number.");
                    }
                    break;

                case "2":
                    Console.Write("Enter the name to search: ");
                    string nameToSearch = Console.ReadLine();
                    int? foundAge = ageManager.GetAge(nameToSearch);
                    if (foundAge.HasValue)
                    {
                        Console.WriteLine($"{nameToSearch}'s age is {foundAge.Value}.");
                    }
                    else
                    {
                        Console.WriteLine($"{nameToSearch} is not found in the dictionary.");
                    }
                    break;

                case "3":
                    Console.Write("Enter the name to remove: ");
                    string nameToRemove = Console.ReadLine();
                    ageManager.RemoveName(nameToRemove);
                    break;

                case "4":
                    ageManager.DisplayAll();
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose between 1 and 5.");
                    break;
            }
        }
    }
}
