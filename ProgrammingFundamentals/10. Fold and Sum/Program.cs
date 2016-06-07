using System;
using System.Linq;

namespace _10.Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] leftFold = arr.Take(arr.Length / 4).Reverse().ToArray();
            int[] rightFold = arr.Skip((arr.Length) - (arr.Length / 4)).Reverse().ToArray();
            int[] row1 = leftFold.Concat(rightFold).ToArray();
            int[] row2 = arr.Skip(arr.Length / 4).Take(arr.Length / 2).ToArray();
            int[] sum = row1.Select((x, index) => x + row2[index]).ToArray();
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
