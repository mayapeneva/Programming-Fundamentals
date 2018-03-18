namespace _2016._09_TrophonTheGrumpyCat
{
    using System;
    using System.Linq;

    public class Trophon
    {
        public static void Main()
        {
            var priceRatings = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var entryPoint = int.Parse(Console.ReadLine());
            var itemTypes = Console.ReadLine();
            var priceRatingTypes = Console.ReadLine();

            var entryPointValue = priceRatings[entryPoint];
            long rightSum = GettingPriceRatingsSum(priceRatings, (entryPoint + 1), priceRatings.Length, itemTypes, entryPointValue, priceRatingTypes);
            long leftSum = GettingPriceRatingsSum(priceRatings, 0, entryPoint, itemTypes, entryPointValue, priceRatingTypes);

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }

        private static long GettingPriceRatingsSum(int[] priceRatings, int start, int end, string itemTypes, int entryPointValue, string priceRatingTypes)
        {
            long sum = 0;
            for (int i = start; i < end; i++)
            {
                if ((itemTypes == "cheap" && priceRatings[i] < entryPointValue)
                    || (itemTypes == "expensive" && priceRatings[i] >= entryPointValue))
                {
                    if ((priceRatingTypes == "positive" && priceRatings[i] > 0)
                        || (priceRatingTypes == "negative" && priceRatings[i] < 0)
                        || (priceRatingTypes == "all"))
                    {
                        sum += priceRatings[i];
                    }
                }
            }

            return sum;
        }
    }
}