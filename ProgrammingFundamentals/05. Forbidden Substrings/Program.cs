using System;
using System.Linq;

namespace _05.Forbidden_Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().ToArray();
            string[] arr = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                for (int w = 0; w < arr.Length; w++)
                {
                    int test = text[i].IndexOf(arr[w]);
                    if (text[i].IndexOf(arr[w]) >= 0)
                    {
                        text[i] = text[i].Replace(arr[w], new string('*', arr[w].Length));
                    }
                }
            }
            Console.WriteLine(string.Join(" ", text));


        }
    }
}
