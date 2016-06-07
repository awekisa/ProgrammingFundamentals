using System;
using System.Linq;

namespace _03.Diagonal_Difference
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];
            int primaryDiag = 0;
            int secondaryDiag = 0;
            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            for (int i = 0; i < size; i++)
            {
                primaryDiag += matrix[i][i];
                secondaryDiag += matrix[i][size-1-i];
            }
            Console.WriteLine(Math.Abs(primaryDiag - secondaryDiag));
        }
    }
}
