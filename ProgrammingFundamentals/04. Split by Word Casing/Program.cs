using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main()
        {
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            string[] arr = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> upper = new List<string>();
            List<string> lower = new List<string>();
            List<string> mixed = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                string result = checkWord(arr[i]);
                if (result.Equals("upper"))
                {
                    upper.Add(arr[i]);
                }
                else if (result.Equals("lower"))
                {
                    lower.Add(arr[i]);
                }
                else
                {
                    mixed.Add(arr[i]);
                }
            }

            Console.WriteLine("Lower-case: {0}\r\nMixed -case: {1}\r\nUpper -case: {2}", string.Join(" ", lower), string.Join(" ", mixed), string.Join(" ", upper));
        }

        private static string checkWord(string input)
        {
            int upper = 0;
            int lower = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (char.IsUpper(ch))
                {
                    upper++;
                }
                else if (char.IsLower(ch))
                {
                    lower++;
                }
            }
            if (upper == input.Length)
            {
                return "upper";
            }
            else if (lower == input.Length)
            {
                return "lower";
            }
            else
            {
                return "mixed";
            }
        }
    }
}
