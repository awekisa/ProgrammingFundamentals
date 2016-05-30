using System;


namespace _21.Numbers_In_Reversed_Order
{
    class NumbersInReversedOrder
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            Console.WriteLine(new String(temp));
        }
    }
}
