using System;


namespace _04.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr[0] = 1;
            long sum;
            for (long i = 1; i < n; i++)
            {
                sum = 0;
                for (long j = i - k; j < i; j++)
                {
                    if (j >= 0)
                    {
                    sum += arr[j];
                    }
                }
                arr[i] = sum;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
