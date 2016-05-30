using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countLeft = 0;
            int countRight = 0;
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int l = 0; l < i; l++)
                {
                    countLeft += arr[l];
                }
                if (i < arr.Length-1)
                {
                for (int r = i+1; r < arr.Length; r++)
                    {
                        countRight += arr[r];
                    }
                }
                if (countLeft == countRight)
                {
                    found = true;
                    Console.WriteLine(i);
                    break;
                }
                countLeft = 0;
                countRight = 0;
            }
            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
