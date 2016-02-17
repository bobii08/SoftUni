namespace _07.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Phonebook
    {
        private static void Main()
        {
            Dictionary<string, HashSet<string>> phonebook = new Dictionary<string, HashSet<string>>();
            string command = Console.ReadLine();
            string entryName = string.Empty;
            string entryNumber = string.Empty;
            while (command != "search")
            {
                string[] strs = command.Split('-');
                entryName = strs[0];
                entryNumber = strs[1];
                if (phonebook.ContainsKey(entryName))
                {
                    phonebook[entryName].Add(entryNumber);
                    command = Console.ReadLine();
                    continue;
                }

                phonebook[entryName] = new HashSet<string>();
                phonebook[entryName].Add(entryNumber);

                command = Console.ReadLine();
            }
            
            string name = Console.ReadLine();
            while (!string.IsNullOrEmpty(name))
            {
                if (phonebook.ContainsKey(name))
                {
                    for (int i = 0; i < phonebook[name].Count; i++)
                    {
                        Console.WriteLine(name + " -> " + phonebook[name].ElementAt(i));
                    }
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", name);
                }

                name = Console.ReadLine();
            }
        }
    }
}