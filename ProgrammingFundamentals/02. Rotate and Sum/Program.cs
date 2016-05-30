using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sum = new int[arr.Length];
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr = shiftRight(arr);
                for (int j = 0; j < arr.Length; j++)
                {
                    sum[j] += arr[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        private static int[] shiftRight(int[] arr)
        {
            int last = arr[arr.Length - 1];
            for (int j = arr.Length - 1; j > 0; j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[0] = last;
            return arr;
        }
    }
}
