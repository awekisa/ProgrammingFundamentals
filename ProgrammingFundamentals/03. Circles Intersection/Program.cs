using System;
using System.Linq;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
class Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }
}

class Program
{
    static void Main()
    {
        int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Point center1 = new Point() { X = arr1[0], Y = arr1[1] };
        Point center2 = new Point() { X = arr2[0], Y = arr2[1] };
        Circle circle1 = new Circle() { Center = center1, Radius = arr1[2] };
        Circle circle2 = new Circle() { Center = center2, Radius = arr2[2] };
        double distance = calculateDistance(center1, center2);
        Console.WriteLine(cirlesIntersect(circle1, circle2, distance) ? "Yes":"No");
    }

    private static bool cirlesIntersect(Circle circle1, Circle circle2, double distance)
    {
        if (distance <= circle1.Radius + circle2.Radius)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static double calculateDistance(Point p1, Point p2)
    {
        double xDistance = Math.Pow((p1.X - p2.X), 2);
        double yDistance = Math.Pow((p1.Y - p2.Y), 2);
        double distance = Math.Sqrt(xDistance + yDistance);
        return distance;
    }
}

