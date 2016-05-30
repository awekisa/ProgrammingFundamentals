using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main()
        {
            char[] alphabet = new char[26];
            alphabet = alphaFill(alphabet);
            char[] arr = Console.ReadLine().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (arr[i] == alphabet[j])
                    {
                    Console.WriteLine($"{arr[i]} -> {j}");
                    }
                }
            }
        }

        private static char[] alphaFill(char[] alphabet)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(97+i);
            }
            return alphabet;
        }
    }
}
