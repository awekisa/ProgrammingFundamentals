using System;

namespace _01.Print_String_Letters
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("str[{0}] -> '{1}'", i, str[i]);
            }
        }
    }
}
