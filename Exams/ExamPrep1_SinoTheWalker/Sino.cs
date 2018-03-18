namespace ExamPrep1_SinoTheWalker
{
    using System;
    using System.Globalization;

    public class Sino
    {
        public static void Main()
        {
            var startTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());

            long startTimeSeconds = (startTime.Hour * 60 * 60) + (startTime.Minute * 60) + startTime.Second;
            ulong secondsToAdd = (ulong)steps * (ulong)secondsPerStep;
            ulong arrivalTimeSeconds = (ulong)startTimeSeconds + secondsToAdd;

            var seconds = arrivalTimeSeconds % 60;
            var tempMinutes = arrivalTimeSeconds / 60;
            var minutes = tempMinutes % 60;
            var tempHours = tempMinutes / 60;
            var hours = tempHours % 24;
            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");
        }
    }
}