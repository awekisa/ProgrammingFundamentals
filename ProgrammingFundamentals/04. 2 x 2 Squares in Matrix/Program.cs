using System;
using System.Linq;

namespace _04._2_x_2_Squares_in_Matrix
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = arr[0];
            int col = arr[1];
            int count = 0;
            char[][] matrix = new char[row][];

            for (int r = 0; r < row; r++)
            {
                matrix[r] = Console.ReadLine().Split().Select(Char.Parse).ToArray();
            }

            for (int r = 0; r < row-1; r++)
            {
                for (int c = 0; c < col-1; c++)
                {
                    if(matrix[r][c] == matrix[r][c+1] && matrix[r][c] == matrix[r+1][c] && matrix[r][c] == matrix[r+1][c + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
