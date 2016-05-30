using System;
using System.Linq;

namespace _06.Rounding_Numbers
{
    class Program
    {
        static void Main()
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (double d in arr)
            {
                Console.WriteLine("{0} => {1}", d, Math.Round(d, 0, MidpointRounding.AwayFromZero));
            }
        }
    }
}
