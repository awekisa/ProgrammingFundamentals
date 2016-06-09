using System;
using System.Globalization;


class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        DateTime date1 = DateTime.ParseExact(first, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime date2 = DateTime.ParseExact(second, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        TimeSpan span = date2 - date1;
        int count = 0;
        for (int i = 0; i <= span.Days; i++)
        {
            if (workingDay(date1))
            {
                count++;
                date1 = date1.AddDays(1);
            }
            else
            {
                date1 = date1.AddDays(1);
            }
        }
        Console.WriteLine(count);
    }

    public static bool workingDay(DateTime date1)
    {
        if (
            date1.DayOfWeek == DayOfWeek.Saturday ||
            date1.DayOfWeek == DayOfWeek.Sunday ||
            (date1.Day.Equals(1) && date1.Month.Equals(1)) ||
            (date1.Day.Equals(3) && date1.Month.Equals(3)) ||
            (date1.Day.Equals(1) && date1.Month.Equals(5)) ||
            (date1.Day.Equals(6) && date1.Month.Equals(5)) ||
            (date1.Day.Equals(24) && date1.Month.Equals(5)) ||
            (date1.Day.Equals(6) && date1.Month.Equals(9)) ||
            (date1.Day.Equals(22) && date1.Month.Equals(9)) ||
            (date1.Day.Equals(1) && date1.Month.Equals(11)) ||
            (date1.Day.Equals(24) && date1.Month.Equals(12)) ||
            (date1.Day.Equals(25) && date1.Month.Equals(12)) ||
            (date1.Day.Equals(26) && date1.Month.Equals(12))
            )
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}

