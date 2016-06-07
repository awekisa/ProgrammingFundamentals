using System;
using System.Linq;

namespace _11.Common_Strings
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int smallLen = Math.Min(a.Length, b.Length);
            bool match = false;
            for (int i = 0; i < smallLen; i++)
            {
                for (int j = 0; j < smallLen; j++)
                {
                    if (match)
                    {
                        break;
                    }
                    if (a.ToCharArray()[i] == b.ToCharArray()[j])
                    {
                        match = true;
                        break;
                    }
                }
            }
            if (match)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
