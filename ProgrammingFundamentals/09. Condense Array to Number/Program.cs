using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Condense_Array_to_Number
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrUpd = new int[arr.Length - 1];
            while (arrUpd.Length > 1)
            {
                for (int i = 0; i < arr.Length-1; i++)
                {
                    arrUpd[i] = arr[i] + arr[i + 1];
                }
                arr = arrUpd;
                arrUpd = new int[arr.Length - 1];
            }
            Console.WriteLine(arr[0]);
        }
    }
}
