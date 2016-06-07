using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Count_Letters_in_String
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine().ToLower();
            List<char> list = str.ToList();
            list.Sort();
            int count = 1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list.Count > 1)
                {
                    if (i == list.Count - 1)
                    {
                        if (list[list.Count-1] == list[i-1])
                        {
                            Console.WriteLine($"{list[i]} -> {count}");
                        }
                        else
                        {
                            count = 1;
                            Console.WriteLine($"{list[i]} -> {count}");
                        }
                    }
                    else
                    {
                        if (list[i] == list[i + 1])
                        {
                            count++;
                        }
                        else
                        {
                            Console.WriteLine($"{list[i]} -> {count}");
                            count = 1;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{list[0]} -> {count}");
                }
            }
            
        }
    }
}
