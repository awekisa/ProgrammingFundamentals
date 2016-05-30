using System;
using System.Numerics;

namespace _26.Factorial
{
    class Factorial
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger factorial = new BigInteger(1);
            for (int i = 1; i <= input; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
