using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> currentSeq = new List<int>();
            currentSeq.Add(arr[0]);
            List<int> longestSeq = new List<int>();
            int number;
            for (int i = 0; i < arr.Length; i++)
            {
                number = arr[i];
                if (i < arr.Length - 1)
                {
                    if (number < arr[i + 1])               // increasing sequence
                    {
                        currentSeq.Add(arr[i + 1]);
                    }
                    else                                  // no increase
                    {
                        if (currentSeq.Count > longestSeq.Count)
                        {
                            longestSeq = new List<int>(currentSeq);
                        }
                        currentSeq.Clear();
                        currentSeq.Add(arr[i + 1]);

                    }
                }
                else                                   // last number
                {
                    if (currentSeq.Count > longestSeq.Count)
                    {
                        longestSeq = new List<int>(currentSeq);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", longestSeq));
        }
    }
}
