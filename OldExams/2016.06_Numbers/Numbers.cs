namespace _2016._06_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Numbers
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split().Select(int.Parse);

            var result = new List<int>();
            var averageNumber = line.Average();
            var sortedLine = line.OrderByDescending(n => n).ToArray();

            for (int i = 0; i < 5; i++)
            {
                if (sortedLine[i] > averageNumber)
                {
                    result.Add(sortedLine[i]);
                }
                else
                {
                    break;
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
