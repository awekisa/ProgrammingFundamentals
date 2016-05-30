using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int sum;
            for (int i = 1; i <= input; i++)
            {
                sum = 0;
                string numberToString = i.ToString();
                for (int j = 0; j < numberToString.Length; j++)
                {
                    sum += (int)char.GetNumericValue(numberToString[j]);
                }
                if(sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
        }
    }
}
