using System;
using System.Collections.Generic;

namespace _08.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] separators = new char[] { ' ', '.', ',', '?', '!' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (isPalindrome(words[i]) && !palindromes.Contains(words[i]))
                {
                    palindromes.Add(words[i]);
                }
            }
            palindromes.Sort();
            Console.WriteLine(string.Join(", ", palindromes));
        }

        private static bool isPalindrome(string word)
        {
            bool palindrome = true;
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length-1 - i])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }
    }
}
