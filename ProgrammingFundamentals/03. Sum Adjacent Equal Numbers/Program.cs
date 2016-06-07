using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main()
        {
            List<decimal> list = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i-1])
                {
                    list[i - 1] *= 2;
                    list.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
