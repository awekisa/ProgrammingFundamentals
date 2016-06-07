using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Censor_Your_Email
{
    class Program
    {
        static void Main()
        {
            string email = Console.ReadLine();
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == email)
                {
                    string[] splitEmail = email.Split('@');
                    splitEmail[0] = new string('*', splitEmail[0].Length);
                    input[i] = string.Join("@", splitEmail);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
