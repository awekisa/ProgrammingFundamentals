using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split('|').ToList();
            list.Reverse();
            foreach (var s in list)
            {
                List<int> subList = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                Console.Write(string.Join(" ", subList) + " ");
            }

        }
    }
}
