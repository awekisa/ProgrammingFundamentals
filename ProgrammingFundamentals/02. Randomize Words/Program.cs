using System;
using System.Linq;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                string temp = arr[i];
                int index = rnd.Next(0, arr.Length);
                arr[i] = arr[index];
                arr[index] = temp;
            }
            foreach(string s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
