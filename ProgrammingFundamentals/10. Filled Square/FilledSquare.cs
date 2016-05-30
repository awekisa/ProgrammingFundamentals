using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Filled_Square
{
    class FilledSquare
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            PrintHeaderRow(input);
            for (int i = 0; i < input - 2; i++)
            {
                PrintMiddleRow(input);
            }
            PrintHeaderRow(input);
        }

        static void PrintMiddleRow(int input)
        {
            String result = "-" + String.Concat(Enumerable.Repeat("\\/", input - 1)) + "-";
            Console.WriteLine(result);
        }

        private static void PrintHeaderRow(int input)
        {
            String result = new string('-', input * 2);
            Console.WriteLine(result);
        }
    }
}
