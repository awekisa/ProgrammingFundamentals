using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i+1 ; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == number)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
