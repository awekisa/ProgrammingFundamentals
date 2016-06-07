using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Largest_Frame_in_Matrix
{
    class Program
    {
        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int[][] matrix = new int[row][];
            for (int i = 0; i < row; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            List<string> rects = new List<string>();

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    string rect = findRect(matrix, row, col);
                    if ()
                    {

                    }
                }
            }

        }
    }
}
