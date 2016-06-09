using System;
using System.Linq;

class Rect
{
    public int Left { get; set; }
    public int Top  { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    
}
class Program
{
    static void Main()
    {
        int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Rect rect1 = new Rect() { Left = arr1[0], Top = arr1[1], Width = arr1[2], Height = arr1[3] };
        Rect rect2 = new Rect() { Left = arr2[0], Top = arr2[1], Width = arr2[2], Height = arr2[3] };

        Console.WriteLine(rect1InsideRect2(rect1, rect2) ? "Inside":"Not inside");
    }

    private static bool rect1InsideRect2(Rect rect1, Rect rect2)
    {
        if (
            rect1.Left >= rect2.Left &&
            rect1.Left + rect1.Width <= rect2.Left + rect2.Width &&
            rect1.Top >= rect2.Top &&
            rect1.Top + rect1.Height <= rect2.Top + rect2.Height
            )
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

