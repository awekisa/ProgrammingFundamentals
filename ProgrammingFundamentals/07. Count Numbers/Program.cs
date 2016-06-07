using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Sort();
            int count = 1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list.Count > 1)
                {
                    if (i == list.Count - 1)
                    {
                        if (list[i] == list[i - 1])
                        {
                            Console.WriteLine($"{list[i]} -> {count}");
                        }
                        else
                        {
                            count = 1;
                            Console.WriteLine($"{list[i]} -> {count}");
                        }
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{list[i]} -> {count}");
                    break;
                }
                
                if (list[i] == list[i+1])
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
    }
}
