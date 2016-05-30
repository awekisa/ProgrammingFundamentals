using System;
using System.Linq;

namespace _10.Extract_Middle_Elements
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] result = ExtractMidle(arr);
            Console.WriteLine("{ " + string.Join(", ", result) + " }");
        }

        private static int[] ExtractMidle(int[] arr)
        {
            int[] result;
            if (arr.Length == 1)
            {
                result = new int[1];
                result[0] = arr[0];
            }
            else if (arr.Length % 2 == 0)
            {
                result = new int[2];
                result[0] = arr[arr.Length / 2 - 1];
                result[1] = arr[arr.Length / 2];
            }
            else
            {
                result = new int[3];
                result[0] = arr[arr.Length/2-1];
                result[1] = arr[arr.Length/2];
                result[2] = arr[arr.Length / 2 + 1];
            }
            return result;
        }
    }
}
