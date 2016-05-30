using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Hello__Name_
{
    class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();
            HelloCompiler(name);
        }

        private static void HelloCompiler(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
