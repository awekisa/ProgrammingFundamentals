using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}
class Program
{
    static void Main()
    {
        double[] arr1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[] arr2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
        Point p1 = new Point() { X = arr1[0], Y = arr1[1] };
        Point p2 = new Point() { X = arr2[0], Y = arr2[1] };
        Console.WriteLine("{0:f3}", calculateDistance(p1, p2));
       
    }

    public static double calculateDistance(Point p1, Point p2)
    {
        double xDistance = Math.Pow((p1.X - p2.X), 2);
        double yDistance = Math.Pow((p1.Y - p2.Y), 2);
        double distance = Math.Sqrt(xDistance + yDistance);
        return distance;
    }
}

