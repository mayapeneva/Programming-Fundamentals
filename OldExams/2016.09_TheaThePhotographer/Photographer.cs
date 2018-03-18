namespace _2016._09_TheaThePhotographer
{
    using System;

    public class Photographer
    {
        public static void Main()
        {
            var picturesAmount = decimal.Parse(Console.ReadLine());
            var filterTimePerPictInSec = decimal.Parse(Console.ReadLine());
            var filterFactor = decimal.Parse(Console.ReadLine());
            var uploadTimePerPictInSec = decimal.Parse(Console.ReadLine());

            var goodPictures = Math.Ceiling(picturesAmount * filterFactor / 100);
            var totalTimeInSec = (picturesAmount * filterTimePerPictInSec) + (goodPictures * uploadTimePerPictInSec);
            var result = TimeSpan.FromSeconds((double)totalTimeInSec);
            Console.WriteLine(string.Format($"{result.Days}:{result.Hours:D2}:{result.Minutes:D2}:{result.Seconds:D2}"));
        }
    }
}