using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
