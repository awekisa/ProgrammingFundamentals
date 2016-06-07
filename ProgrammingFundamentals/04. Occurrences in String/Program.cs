using System;

namespace _04.Occurrences_in_String
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int count = 0;
            int index = 0;

            while (str.IndexOf(pattern, index) != -1)
            {
                count++;
                index = str.IndexOf(pattern, index) + 1;
            }
            Console.WriteLine(count);

        }
    }
}
