using System;
using System.Linq;

namespace _08.Sum_Arrays
{
    class Program
    {
        static void Main()
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (first.Length > second.Length)
            {
                Console.WriteLine(string.Join(" ", SumArrays(first, second)));
            }
            else
            {
            Console.WriteLine(string.Join(" ", SumArrays(second, first)));
            }
        }

        private static int[] SumArrays(int[] first, int[] second)
        {
            int sum = 0;
            int[] result = new int[first.Length];
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < first.Length; j++)
                {
                    sum = first[i] + (second[i % second.Length]);
                    result[i] = sum;
                }
            }
            return result;
        }
    }
}
