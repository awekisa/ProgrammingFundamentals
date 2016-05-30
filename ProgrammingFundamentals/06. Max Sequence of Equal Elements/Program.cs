using System;
using System.Linq;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int seq = arr[0];
            int tempSeq = seq;
            int longestCount = 0;
            int currentCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == tempSeq)
                {
                    currentCount++;
                    if (i == arr.Length - 1)
                    {
                        if (currentCount > longestCount)
                        {
                            longestCount = currentCount;
                            seq = tempSeq;
                        }
                    }
                }
                else
                {                    
                    if (currentCount > longestCount)
                    {
                        longestCount = currentCount;
                        seq = tempSeq;
                    }
                    tempSeq = arr[i];
                    currentCount = 1;
                }
            }
            if (longestCount == 0) longestCount = currentCount;
            for (int i = 0; i < longestCount; i++)
            {
                Console.Write(seq + " ");
            }
        }
    }
}
