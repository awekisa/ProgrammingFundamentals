﻿using System;
using System.Collections.Generic;

namespace _24.Primes_in_Given_Range
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());
            List<long> primeList = new List<long>();
            for (long i = start; i <= end; i++)
            {
                primeList = FindPrimesInRange(i, primeList);
            }
            Console.WriteLine(String.Join(", ", primeList));   
        }

        private static List<long> FindPrimesInRange(long number, List<long> primeList)
        {
            if (isPrime(number))
            {
                primeList.Add(number);
            }
            return primeList;
        }

        private static bool isPrime(long number)
        {
            if ((number & 1) == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (long i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return number != 1;
        }
    }
}
