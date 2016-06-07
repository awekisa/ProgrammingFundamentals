using System;
using System.Linq;

namespace _09.Rotate_a_Matrix
{
    class Program
    {
        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            string[][] matrix = new string[row][];
            matrix = fillMatrix(matrix, row, col);

            int rotatedRow = col;
            int rotatedCol = row;

            for (int r = 0; r < rotatedRow; r++)
            {
                for (int c = rotatedCol - 1; c >= 0; c--)
                {
                    Console.Write(matrix[c][r] + " ");
                }
                Console.WriteLine();
            }
        }

        private static string[][] fillMatrix(string[][] matrix, int row, int col)
        {
            for (int r = 0; r < row; r++)
            {
                matrix[r] = Console.ReadLine().Split().ToArray();
            }
            return matrix;
        }
    }
}
