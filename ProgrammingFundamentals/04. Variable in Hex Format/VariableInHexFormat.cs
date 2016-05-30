using System;

namespace _04.Variable_in_Hex_Format
{
    class VariableInHexFormat
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(input, 16));
        }
    }
}
