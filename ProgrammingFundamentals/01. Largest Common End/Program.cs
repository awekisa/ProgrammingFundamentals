using System;
using System.Linq;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main()
        {
            string[] first = Console.ReadLine().Split().ToArray();
            string[] second = Console.ReadLine().Split().ToArray();
            int leftSeq = 0;
            int rightSeq = 0;
            int len1 = first.Length;
            int len2 = second.Length;
            int shorter = Math.Min(len2, len1);
            // left seq
            for (int i = 0; i < shorter; i++)
            { 
                if (first[i] == second[i])
                {
                    leftSeq++;
                }
                else
                {
                    break;
                }
            }
        //right se
        
            for (int i = len1 - 1, j = len2-1; Math.Min(j, i) >= 0; i--, j--)
            {
                if (first[i] == second[j])
                {
                    rightSeq++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Math.Max(leftSeq, rightSeq));
        }
    }
}
