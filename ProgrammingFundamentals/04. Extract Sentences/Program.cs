using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Extract_Sentences
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            char[] separators = new char[] { '.', '!', '?' };
            List<string> seq = text.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < seq.Count; i++)
            {
                seq[i] = seq[i].Trim();
                string check = new string(seq[i].ToCharArray().Where(c => char.IsLetter(c) || c == ' ' || c == '-' || Char.IsDigit(c)).ToArray());
                string[] sentence = check.Split();
                if (!sentence.Contains(word))
                {
                    seq.Remove(seq[i]);
                    i--;
                }
                
            }
            Console.WriteLine(string.Join("\r\n", seq));
        }
    }
}
