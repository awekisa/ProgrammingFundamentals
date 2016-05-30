using System;


namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int[] arr = new int[input];
            for (int i = 0; i < input; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
