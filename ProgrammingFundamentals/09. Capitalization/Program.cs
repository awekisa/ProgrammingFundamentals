using System;

namespace _09.Capitalization
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            char[] separators = new char[] { ' ', '.', ',', '?', '!', ';' };
            string[] arr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                string toUpper = arr[i];
                char first = toUpper[0];
                toUpper = toUpper.Remove(0, 1);
                toUpper = toUpper.Insert(0, first.ToString().ToUpper());
                arr[i] = toUpper;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
