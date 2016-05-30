using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greeting
{
    class Greeting
    {
        static void Main()
        {
            String firstName = Console.ReadLine();
            String lastName = Console.ReadLine();
            String age = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
        }
    }
}
