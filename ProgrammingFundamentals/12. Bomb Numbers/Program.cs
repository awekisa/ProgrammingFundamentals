using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = arr[0];
            int power = arr[1];

            for (int i = 0; i < list.Count; i++)
            {
                // hit
                if (list[i] == bomb)
                {
                    int leftIndex = 0;
                    int rightIndex = 0;
                    // check left
                    if (i - power < 0)
                    {
                        leftIndex = 0;
                    }
                    else
                    {
                        leftIndex = i - power;
                    }
                    // check right
                    if (i + power > list.Count - 1)
                    {
                        rightIndex = list.Count - 1;
                    }
                    else
                    {
                        rightIndex = i + power;
                    }
                    for (int j = leftIndex; j <= rightIndex; j++)
                    {
                        list.RemoveAt(j);
                        j--;
                        rightIndex--;
                    }
                    if (i - (power+1) < -1)
                    {
                        i = -1;
                    }
                    else
                    {
                        i -= power + 1;
                    }
                }
            }

            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);

        }
    }
}
