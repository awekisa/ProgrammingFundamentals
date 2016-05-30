using System;
using System.Linq;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] baseArr = new int[input.Length / 2];
            int[] folded = new int[baseArr.Length];
            baseArr = baseFill(input, baseArr);
            folded = foldedFill(input, folded);

            for (int i = 0; i < baseArr.Length; i++)
            {
                Console.Write(baseArr[i] + folded[i] + " ");
            }
        }

        private static int[] foldedFill(int[] input, int[] folded)
        {
            // left array
            int[] leftArr = new int[input.Length / 4];
            for (int i = 0; i < leftArr.Length; i++)
            {
                leftArr[i] = input[i];
            }
            Array.Reverse(leftArr);
            // right array
            int[] rightArr = new int[input.Length/4];
            Array.Reverse(input);
            for (int i = 0; i < rightArr.Length; i++)
            {
                rightArr[i] = input[i];
            }
            //Array.Reverse(rightArr);
            int[] result = leftArr.Concat(rightArr).ToArray();
            return result;
            

        }

        private static int[] baseFill(int[] input, int[] baseArr)
        {
            int len = input.Length;
            for (int i = 0; i < len/2; i++)
            {
                baseArr[i] = input[i+len/4];
            }
            return baseArr;
        }
    }
}
