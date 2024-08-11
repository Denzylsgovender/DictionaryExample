using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    public class AgeDictionaryManager
    {
        private Dictionary<string, int> ageDictionary;

        public AgeDictionaryManager()
        {
            // Initialize the dictionary.
            ageDictionary = new Dictionary<string, int>();
        }

        public void AddAge(string name, int age)
        {
            // Add a key-value pair to the dictionary.
            ageDictionary[name] = age;

        }

        public int? GetAge(string name)
        {
            // Retrieve the value by key, or return null if the key doesn't exist.
            if (ageDictionary.ContainsKey(name))
            {
                return ageDictionary[name];
            }
            return null;
        }

        public bool ContainsName(string name)
        {
            // Check if the key exists in the dictionary.
            return ageDictionary.ContainsKey(name);
        }

        public bool RemoveName(string name)
        {
            // Remove a key-value pair from the dictionary.
            if (ageDictionary.ContainsKey(name))
            {
                ageDictionary.Remove(name);
                Console.WriteLine($"{name} has been removed from the dictionary.");
                return true;
            }
            else
            {
                Console.WriteLine($"{name} is not found in the dictionary.");
                return false;
            }
        }

        public void DisplayAll()
        {
            // Display all key-value pairs in the dictionary.
            if (ageDictionary.Count > 0)
            {
                Console.WriteLine("Current contents of the dictionary:");
                foreach (var kvp in ageDictionary)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
            else
            {
                Console.WriteLine("The dictionary is empty.");
            }
        }
    }
}
