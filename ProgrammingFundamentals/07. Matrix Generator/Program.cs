using System;

namespace _07.Matrix_Generator
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            string type = input[0];
            int row = int.Parse(input[1]);
            int col = int.Parse(input[2]);
            long[,] matrix = new long[row, col];

            if (type == "A")
            {
                matrix = aType(matrix, row, col);
            }
            else if (type == "B")
            {
                matrix = bType(matrix, row, col);
            }
            else if (type == "C")
            {
                matrix = cType(row, col);
            }
            else // type D
            {
                matrix = dType(row, col);
            }
            printMatrix(matrix, row, col);
        }

        private static long[,] dType(int row, int col)
        {
            long[,] matrix = new long[row, col];
            int count = 1;
            int r = 0;
            int c = 0;
            int max = row * col;
            while (count <= max)
            {
                if (row == 1 && col == 1)
                {
                    matrix[0, 0] = 1;
                    break;
                }
                //down
                if (count > max) break;
                for (int d = r; d < row-1; d++)
                {
                    matrix[d, c] = count;
                    count++;
                    if (count > max) break;
                }
                //right
                if (count > max) break;
                for (int d = c; d < col-1; d++)
                {
                    matrix[row-1, d] = count;
                    count++;
                    if (count > max) break;
                }
                // up
                if (count > max) break;
                for (int d = row - 1; d > r; d--)
                {
                    matrix[d, col-1] = count;
                    count++;
                    if (count > max) break;
                }
                // left
                if (count > max) break;
                for (int d = col - 1; d > c; d--)
                {
                    matrix[r, d] = count;
                    count++;
                    if (count > max) break;
                }
                row--;
                col--;
                r++;
                c++;
            }

            return matrix;
        }

        private static long[,] cType(int row, int col)
        {
            int[][] matrix = new int[row + (col - 1)][];
            int count = 1;
            for (int r = 0; r < row; r++)
            {
                matrix[r] = new int[1 + r];
            }
            for (int r = 0; r < col-1; r++)
            {
                matrix[row + r] = new int[col - 1 - r];
            }
            // Filling the matrix
            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[r].Length; c++)
                {
                    matrix[r][c] = count;
                    count++;
                }
            }
            // Converting matrix
            long[,] convertedMatrix = new long[row, col];
            int R = row - 1;
            int C = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (i < row)
                {
                    convertedMatrix[R, C] = matrix[i][C];
                    int diagR = R + 1;
                    int diagC = C + 1;
                    int index = 1;
                    while (diagR < row && diagC < col)
                    {
                        convertedMatrix[diagR,diagC] = matrix[i][index];
                        index++;
                        diagR++;
                        diagC++;
                    }
                    R--;
                }
                else
                {
                    C++;
                    int cTemp = C;
                    R = 0;
                    int index = 0;
                    for (int d = row; d < matrix[i].Length+row; d++)
                    {
                        convertedMatrix[R, cTemp] = matrix[i][index];
                        index++;
                        R++;
                        cTemp++;
                    }
                }
            }

            return convertedMatrix;
        }

        private static long[,] aType(long[,] matrix, int row, int col)
        {
            int count = 1;
            for (int c = 0; c < col; c++)
            {
                for (int r = 0; r < row; r++)
                {
                    matrix[r, c] = count;
                    count++;
                }
            }
            return matrix;
        }

        private static long[,] bType(long[,] matrix, int row, int col)
        {
            int count = 1;
            for (int c = 0; c < col; c++)
            {
                for (int r = 0; r < row; r++)
                {
                    if (c % 2 == 0)
                    {
                        matrix[r, c] = count;
                        count++;
                    }
                    else
                    {
                        matrix[row - 1 - r, c] = count;
                        count++;
                    }
                }
            }
            return matrix;
        }

        private static void printMatrix(long[,] matrix, int row, int col)
        {
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write(matrix[r,c] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
