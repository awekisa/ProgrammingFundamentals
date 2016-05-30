using System;


namespace _09.Reversed_chars
{
    class ReversedChars
    {
        static void Main()
        {
            char[] array = new char[3];
            array[0] = char.Parse(Console.ReadLine());
            array[1] = char.Parse(Console.ReadLine());
            array[2] = char.Parse(Console.ReadLine());
            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.Write(item);
            }
        }
    }
}
