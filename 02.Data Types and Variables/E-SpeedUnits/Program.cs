using System;

namespace E_ConvertSpeedUnits
{
    public class Program
    {
        private static void Main()
        {
            var distanceInMeters = float.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            float distanceInKilometers = distanceInMeters / 1000;
            float distanceInMiles = distanceInMeters / 1609;
            float totalTimeInSeconds = seconds + (minutes * 60f) + (hours * 3600f);
            float totalTimeInHours = hours + (minutes / 60f) + (seconds / 3600f);

            Console.WriteLine(distanceInMeters / totalTimeInSeconds);
            Console.WriteLine(distanceInKilometers / totalTimeInHours);
            Console.WriteLine(distanceInMiles / totalTimeInHours);
        }
    }
}