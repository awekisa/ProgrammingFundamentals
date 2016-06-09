using System;
using System.Collections.Generic;
using System.Linq;


class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Point> list = new List<Point>();
        for (int i = 0; i < n; i++)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point p = new Point() { X = arr[0], Y = arr[1] };
            list.Add(p);
        }
        List<Point> result = FindClosestPoints(list);
        Console.WriteLine("{0:f3}", calculateDistance(result[0], result[1]));
        foreach (Point p in result)
        {
            Console.WriteLine("({0}, {1})", p.X, p.Y);
        }
    }

    public static List<Point> FindClosestPoints(List<Point> list)
    {
        List<Point> result = new List<Point>();
        double closestDistance = double.MaxValue;
        double tempDistance;
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (i != j)
                {
                    tempDistance = calculateDistance(list[i], list[j]);
                    if (tempDistance < closestDistance)
                    {
                        closestDistance = tempDistance;
                        result.Clear();
                        result.Add(list[i]);
                        result.Add(list[j]);
                    }
                }
            }
        }
        return result;
    }
    public static double calculateDistance(Point p1, Point p2)
    {
        double xDistance = Math.Pow((p1.X - p2.X), 2);
        double yDistance = Math.Pow((p1.Y - p2.Y), 2);
        double distance = Math.Sqrt(xDistance + yDistance);
        return distance;
    }
}

