﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main()
        {
            long sum = 0;
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {

                char[] temp = arr[i].ToString().ToCharArray();
                Array.Reverse(temp);
                int number = int.Parse(new string(temp));
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
