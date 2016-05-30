using System;


namespace _07.Exchange_Variable_Values
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int temp;
            Console.WriteLine("Before:\r\na = {0}\r\nb = {1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After:\r\na = {0}\r\nb = {1}", a, b);
        }
    }
}
