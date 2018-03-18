namespace HornetWings
{
    using System;

    public class Wings
    {
        public static void Main()
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var metersForHundredFlaps = decimal.Parse(Console.ReadLine());
            var enduranceInFlaps = int.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * metersForHundredFlaps;
            var timeInSeconds = (wingFlaps / 100) + ((wingFlaps / enduranceInFlaps) * 5);

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{timeInSeconds} s.");
        }
    }
}