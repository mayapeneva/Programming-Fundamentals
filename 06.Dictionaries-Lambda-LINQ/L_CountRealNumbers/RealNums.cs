namespace L_CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RealNums
    {
        public static void Main()
        {
            var initialList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var ascendingNumbers = new SortedDictionary<double, int>();
            for (int i = 0; i < initialList.Count; i++)
            {
                if (!ascendingNumbers.ContainsKey(initialList[i]))
                {
                    ascendingNumbers[initialList[i]] = 0;
                }

                ascendingNumbers[initialList[i]]++;
            }

            foreach (var number in ascendingNumbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}