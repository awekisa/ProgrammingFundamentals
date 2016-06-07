using System;
using System.Collections.Generic;

namespace _12.Phonebook
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
            while(input != "END")
            {
                string[] arr = input.Split();
                if (arr[0] == "A")
                {
                    phoneNumbers[arr[1]] = arr[2];
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
