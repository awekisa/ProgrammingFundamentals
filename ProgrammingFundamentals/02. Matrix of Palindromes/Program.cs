using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Matrix_of_Palindromes
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = arr[0];
            int col = arr[1];
            string[][] matrix = new string[row][];
            for (int r = 0; r < row; r++)
            {
                string[] newRow = new string[col];
                matrix[r] = newRow;
                for (int c = 0; c < col; c++)
                {
                    string fill = new string((char)(97 + r), 3);
                    matrix[r][c] = fill;
                    StringBuilder sb = new StringBuilder(matrix[r][c]);
                    sb[1] = (char)(97 + r + c);
                    matrix[r][c] = sb.ToString();
                }
            }
            for (int r = 0; r < row; r++)
            {
                Console.Write(String.Join(" ", matrix[r]));
                Console.WriteLine();
            }
        }
    }
}
