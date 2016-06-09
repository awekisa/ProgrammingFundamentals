using System;
using System.Globalization;

namespace _01.Day_of_Week_Obj_and_Classes_
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
