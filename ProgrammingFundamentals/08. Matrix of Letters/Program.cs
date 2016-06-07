using System;

namespace _08.Matrix_of_Letters
{
    class Program
    {
        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            char letter = 'A';
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write(letter + " ");
                    letter++;
                }
                Console.WriteLine();
            }
        }
    }
}
