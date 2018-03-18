namespace _2016._06_SampleExam_WaterSupplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WaterSupplies
    {
        public static void Main()
        {
            var totalAmountOfWater = decimal.Parse(Console.ReadLine());
            var allBottlesList = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            var oneBottleCapacity = decimal.Parse(Console.ReadLine());

            var bottlesToFillCapacity = allBottlesList.Count * oneBottleCapacity - allBottlesList.Sum();
            var difference = totalAmountOfWater - bottlesToFillCapacity;
            if (totalAmountOfWater >= bottlesToFillCapacity)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {difference}l.");
            }
            else
            {
                Console.WriteLine("We need more water!");

                var emptyBottlesList = new List<int>();
                if (totalAmountOfWater % 2 == 0)
                {
                    for (int i = 0; i < allBottlesList.Count; i++)
                    {
                        if (allBottlesList[i] < oneBottleCapacity)
                        {
                            totalAmountOfWater -= (oneBottleCapacity - allBottlesList[i]);
                        }

                        if (totalAmountOfWater < 0)
                        {
                            emptyBottlesList.Add(i);
                        }
                    }
                }
                else
                {
                    for (int j = allBottlesList.Count - 1; j >= 0; j--)
                    {
                        if (allBottlesList[j] < oneBottleCapacity)
                        {
                            totalAmountOfWater -= (oneBottleCapacity - allBottlesList[j]);
                        }

                        if (totalAmountOfWater < 0)
                        {
                            emptyBottlesList.Add(j);
                        }
                    }
                }

                Console.WriteLine($"Bottles left: {emptyBottlesList.Count}");
                Console.WriteLine($"With indexes: {string.Join(", ", emptyBottlesList)}");
                Console.WriteLine($"We need {Math.Abs(difference)} more liters!");
            }
        }
    }
}
