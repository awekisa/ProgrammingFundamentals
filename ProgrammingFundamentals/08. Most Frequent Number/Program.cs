using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            numbers.Add(arr[0], 0);
            for (int i = 0; i < arr.Length; i++)
            {
                if (numbers.ContainsKey(arr[i]))
                {
                    numbers[arr[i]] += 1;
                }
                else
                {
                    numbers.Add(arr[i], 1);
                }
            }
            int index = 0;
            foreach (KeyValuePair<int, int> item in numbers)
            {
                if (item.Value > index)
                {
                    index = item.Value;
                }
            }
            Console.WriteLine(numbers.FirstOrDefault(x => x.Value == index).Key);
        }
    }
}
