using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main()
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> result = new List<double>();
            for (int i = 0; i < list.Count; i++)
            {
                double a = Math.Sqrt(list[i]);
                int b = (int)Math.Sqrt(list[i]);
                if (Math.Sqrt(list[i]) == (int)Math.Sqrt(list[i]))
                {
                    result.Add(list[i]);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
