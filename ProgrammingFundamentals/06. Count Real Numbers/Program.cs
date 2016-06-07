using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> dict = new SortedDictionary<double, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict[arr[i]] = 1;
                }
            }
            foreach (var n in dict)
            {
                Console.WriteLine("{0} -> {1}", n.Key, n.Value);
            }
        }
    }
}
