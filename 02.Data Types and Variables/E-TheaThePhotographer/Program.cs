using System;

namespace E_ThePhotographer
{
    public class Program
    {
        private static void Main()
        {
            var picturesTaken = long.Parse(Console.ReadLine());
            var filterTimeInSeconds = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTimeInSeconds = int.Parse(Console.ReadLine());

            long picturesFiltered = (int)Math.Ceiling((picturesTaken * (decimal)filterFactor) / 100m);
            long totalTimeInSeconds = (picturesTaken * filterTimeInSeconds) + (picturesFiltered * uploadTimeInSeconds);

            Console.WriteLine(TimeSpan.FromSeconds(totalTimeInSeconds).ToString(@"d\:hh\:mm\:ss"));
        }
    }
}