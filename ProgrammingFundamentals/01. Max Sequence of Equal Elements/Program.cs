using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int longestIndex = 0;
            int tempIndex = 0;
            int longestSeq = 1;
            int tempSeq = 1;

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    tempSeq++;
                    if (i == list.Count-2)
                    {
                        if (tempSeq > longestSeq)
                        {
                            longestSeq = tempSeq;
                            longestIndex = tempIndex;
                        }
                    }
                }
                else
                {
                    if (tempSeq > longestSeq)
                    {
                        longestSeq = tempSeq;
                        longestIndex = tempIndex;
                    }
                        tempSeq = 1;
                        tempIndex = i+1;
                }
            }
            for (int i = longestIndex; i < longestIndex+longestSeq; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
