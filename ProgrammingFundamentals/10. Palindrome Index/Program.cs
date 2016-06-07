using System;

namespace _10.Palindrome_Index
{
    class Program
    {
        static void Main()
        {
            string pal = Console.ReadLine();
            string temp = pal;
            int index = -1;

            while (!isPalindrome(temp))
            {
                index++;
                temp = pal;
                temp = temp.Remove(index, 1);
            }
            Console.WriteLine(index);

        }
        private static bool isPalindrome(string pal)
        {
            bool palindrome = true;
            for (int i = 0; i < pal.Length / 2; i++)
            {
                if (pal[i] != pal[pal.Length - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }
    }
}
