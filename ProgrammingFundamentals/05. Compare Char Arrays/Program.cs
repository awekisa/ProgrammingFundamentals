using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main()
        {
            char[] a = Console.ReadLine().Split().Select(e => Convert.ToChar(e)).ToArray();
            char[] b = Console.ReadLine().Split().Select(e => Convert.ToChar(e)).ToArray();
            firstCharArray(a, b);


        }

        private static void firstCharArray(char[] a, char[] b)
        {
            bool sameChar = false;
            bool firstCharArray = false;
            bool secondCharAray = false;
            int len = Math.Min(a.Length, b.Length);
            for (int i = 0; i < len; i++)
            {
                if (a[i] == b[i])
                {
                    sameChar = true;
                }
                else if (a[i] < b[i])
                {
                    firstCharArray = true;
                    break;
                }
                else
                {
                    secondCharAray = true;
                    break;
                }                
            }
            if (sameChar)
            {
            if (a.Length < b.Length)
            {
                firstCharArray = true;
            }
            else
            {
                secondCharAray = true;
            }

            }

            if (firstCharArray)
            {
                Console.WriteLine(String.Join("", a));
                Console.WriteLine(String.Join("", b));
            }
            else if(secondCharAray)
            {
                Console.WriteLine(String.Join("", b));
                Console.WriteLine(String.Join("", a));
            }
        }
    }
}
