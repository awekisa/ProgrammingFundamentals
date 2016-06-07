using System;
using System.Linq;

namespace _06.Hourglass_Sum
{
    class Program
    {
        static void Main()
        {
            long[][] matrix = new long[6][];
            for (int r = 0; r < 6; r++)
            {
                matrix[r] = Console.ReadLine().Split().Select(long.Parse).ToArray();
            }
            long maxSum = long.MinValue;
            long tempSum = 0;

            for (int r = 0; r < 6-2; r++)
            {
                for (int c = 0; c < 6-2; c++)
                {
                    tempSum = checkHourlass(matrix, r, c);
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }

        private static long checkHourlass(long[][] matrix, int row, int col)
        {
            long sum = 0;
            for (int c = col; c < col+3; c++)
            {
                sum += matrix[row][c];
            }
            sum += matrix[row + 1][col + 1];
            for (int c = col; c < col+3; c++)
            {
                sum += matrix[row+2][c];
            }
            return sum;
        }
    }
}
