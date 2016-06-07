using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Short_Words_Sorted
{
    class Program
    {
        static void Main()
        {
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', ',', '\\', '/', '!', '?', ' ' };
            string[] arr = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var result = arr.Where(x => x.Length < 5).OrderBy(x => x).Distinct();
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
