using System;
using System.Linq;

namespace _03.Sum__Min__Max__First__Last__Average
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int[] arr = new int[input];
            for (int i = 0; i < input; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(arr.Sum());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.First());
            Console.WriteLine(arr.Last());
            Console.WriteLine(arr.Average());
        }
    }
}
