using System;


namespace _19.Max_Method
{
    class MaxMethod
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetMax(a, GetMax(b, c)));
        }

        private static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
