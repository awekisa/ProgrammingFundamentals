using System;
using System.Linq;

namespace _03.Print_a_Receipt
{
    class Program
    {
        static void Main()
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double total = 0;
            Console.WriteLine("/" + new string('-', 22) + '\\');
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("| {0,20:f2} |", arr[i]);
                total += arr[i];
            }
            Console.WriteLine("|" + new string('-', 22) + "|");
            Console.WriteLine("| Total:{0,14:f2} |", total);
            Console.WriteLine("\\" + new string('-', 22) + '/');
        }
    }
}
