using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class ExactSumOfRealNumbers
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());
            decimal number;
            decimal sum = 0 ;
            for (int i = 0; i < entries; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
