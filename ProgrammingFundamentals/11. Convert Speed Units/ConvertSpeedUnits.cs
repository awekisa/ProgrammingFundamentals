using System;


namespace _11.Convert_Speed_Units
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float speedMetersPerSecond = distance / ((hours * 60 + minutes) * 60 + seconds);
            float speedKilometersPerHour = (distance / 1000) / (hours + (minutes / 60) + (seconds / 60 / 60));
            float speedMilesPerHour = (distance / 1609) / (hours + (minutes / 60) + (seconds / 60 / 60));
            Console.WriteLine(speedMetersPerSecond);
            Console.WriteLine(speedKilometersPerHour);
            Console.WriteLine(speedMilesPerHour);
        }
    }
}
