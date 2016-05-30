using System;


namespace _01.Day_of_Week
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string[] week = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            if (input >= 1 && input <= 7)
            {
            Console.WriteLine(week[input-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
