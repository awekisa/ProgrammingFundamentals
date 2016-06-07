using System;
using System.Collections.Generic;

namespace _13.Phonebook_Upgrade
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            SortedDictionary<string, string> phoneNumbers = new SortedDictionary<string, string>();
            while (input != "END")
            {
                string[] arr = input.Split();
                if (arr[0] == "A")
                {
                    phoneNumbers[arr[1]] = arr[2];
                }
                else if (input == "ListAll")
                {
                    foreach (var number in phoneNumbers)
                    {
                        Console.WriteLine("{0} -> {1}", number.Key, number.Value);
                    }
                }
                else
                {
                    if (phoneNumbers.ContainsKey(arr[1]))
                    {
                        Console.WriteLine($"{arr[1]} -> {phoneNumbers[arr[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {arr[1]} does not exist.");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
