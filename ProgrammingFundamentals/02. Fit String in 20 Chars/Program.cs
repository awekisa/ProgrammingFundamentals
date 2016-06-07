using System;
using System.Linq;

namespace _02.Fit_String_in_20_Chars
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            if (str.Length > 20)
            {
                char[] charArr = str.ToCharArray();
                charArr = charArr.Take(20).ToArray();
                str = string.Join("", charArr);
            }
            else
            {
                str = str + new string('*', 20 - str.Length);
            }
            Console.WriteLine(str);
        }
    }
}
