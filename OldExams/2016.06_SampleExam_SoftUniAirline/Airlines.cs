namespace _2016._06_SampleExam_SoftUniAirline
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Airlines
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var totalProfit = new List<decimal>();
            for (int i = 0; i < n; i++)
            {
                var adultsCount = int.Parse(Console.ReadLine());
                var adultPrice = decimal.Parse(Console.ReadLine());
                var youthCount = int.Parse(Console.ReadLine());
                var youthPrice = decimal.Parse(Console.ReadLine());
                var fuelPricePerHour = decimal.Parse(Console.ReadLine());
                var fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                var flightDuration = int.Parse(Console.ReadLine());

                var income = (adultsCount * adultPrice) + (youthCount * youthPrice);
                var expences = fuelConsumptionPerHour * fuelPricePerHour * flightDuration;
                var profit = income - expences;

                if (profit >= 0)
                {
                    Console.WriteLine($"You are ahead with {profit:F3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:F3}$.");
                }

                totalProfit.Add(profit);
            }

            Console.WriteLine($"Overall profit -> {totalProfit.Sum():F3}$.");
            Console.WriteLine($"Average profit -> {totalProfit.Average():F3}$.");
        }
    }
}
