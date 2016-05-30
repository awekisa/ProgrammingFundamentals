using System;


namespace _14.Integer_to_Hex_and_Binary
{
    class IntegerToHexAndBinary
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input.ToString("X"));
            Console.WriteLine(Convert.ToString(input, 2));  
        }
    }
}
