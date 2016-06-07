using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().ToLower().Split().ToArray();
            Dictionary<string, double> dict = new Dictionary<string, double>();
            List<string> result = new List<string>();
            foreach (var str in arr)
            {
                if (dict.ContainsKey(str))
                {
                    dict[str]++;
                }
                else
                {
                    dict[str] = 1;
                }
            }
            foreach (var key in dict)
            {
                if (key.Value % 2 == 1)
                {
                    result.Add(key.Key);
                }
            }
            
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
