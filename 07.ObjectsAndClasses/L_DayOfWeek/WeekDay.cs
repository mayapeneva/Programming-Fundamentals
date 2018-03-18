namespace L_DayOfWeek
{
    using System;
    using System.Globalization;

    public class WeekDay
    {
        public static void Main()
        {
            var date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}