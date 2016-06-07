using System;
using System.Linq;

namespace _05.Max_Platform_3_x_3
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = arr[0];
            int col = arr[1];
            long count = 0;
            int indexRow = 0;
            int indexCol = 0;
            long tempCount = 0;
            long[][] matrix = new long[row][];

            for (int r = 0; r < row; r++)
            {
                matrix[r] = Console.ReadLine().Split().Select(long.Parse).ToArray();
            }
            count = checkPlatform(matrix, 0, 0);

            for (int r = 0; r < row-2; r++)
            {
                for (int c = 0; c < col-2; c++)
                {
                    tempCount = checkPlatform(matrix, r, c);
                    if(tempCount > count)
                    {
                        count = tempCount;
                        indexRow = r;
                        indexCol = c;
                    }
                }
            }
            Console.WriteLine(count);
            for (int r = indexRow; r < indexRow+3; r++)
            {
                for (int c = indexCol; c < indexCol+3; c++)
                {
                    Console.Write(matrix[r][c] + " ");
                }
                Console.WriteLine();
            }
        }

        private static long checkPlatform(long[][] matrix, int row, int col)
        {
            long count = 0;
            for (int r = row; r < row+3; r++)
            {
                for (int c = col; c < col+3; c++)
                {
                    count += matrix[r][c];
                }
            }
            return count;
        }
    }
}
