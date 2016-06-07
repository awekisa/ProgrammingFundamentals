using System;
using System.Linq;

namespace _13.Tour
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int r = 0; r < n; r++)
            {
                matrix[r] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            int[] destinations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            int lastCity = 0;

            for (int d = 0; d < destinations.Length; d++)
            {
                int city = destinations[d];
                count += matrix[lastCity][city];
                lastCity = destinations[d];
            }
            Console.WriteLine(count);

            int[,] mat = new int[3, 4];


            int[][] mat2 = new int[3][];
            mat2[0] = new int[] { 2, 3, 4};
            mat2[1] = new int[] { 1, 2 };
        }
    }
}
