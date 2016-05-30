using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Prime_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool [] arr = Enumerable.Repeat(true, number+1).ToArray();
            arr[0] = arr[1] = false;
            for (int i = 0; i <= number; i++)
            {
                if (arr[i] == true)
                {
                    Console.Write(i + " ");
                    for (int j = 2*i; j <= number; j+=i)
                    {
                        arr[j] = false;
                    }
                }
            }
        }
    }
}
