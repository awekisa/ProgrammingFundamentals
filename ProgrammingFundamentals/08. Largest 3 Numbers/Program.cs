using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> result = nums.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", result)); 
        }
    }
}
