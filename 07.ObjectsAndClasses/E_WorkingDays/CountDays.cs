namespace E_WorkingDays
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class CountDays
    {
        public static void Main()
        {
            var firstDateInput = Console.ReadLine();
            var secondDateInput = Console.ReadLine();

            var firstDate = DateTime.ParseExact(firstDateInput, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(secondDateInput, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidaysList = new List<DateTime>()
            {
                new DateTime(secondDate.Year, 01, 01),
                new DateTime(secondDate.Year, 03, 03),
                new DateTime(secondDate.Year, 05, 01),
                new DateTime(secondDate.Year, 05, 06),
                new DateTime(secondDate.Year, 05, 24),
                new DateTime(secondDate.Year, 09, 06),
                new DateTime(secondDate.Year, 09, 22),
                new DateTime(secondDate.Year, 11, 01),
                new DateTime(secondDate.Year, 12, 24),
                new DateTime(secondDate.Year, 12, 25),
                new DateTime(secondDate.Year, 12, 26)
            };

            var counter = 0;
            for (DateTime i = firstDate; i <= secondDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday 
                    && !holidaysList.Any(x => x.Day == i.Day && x.Month == i.Month))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}