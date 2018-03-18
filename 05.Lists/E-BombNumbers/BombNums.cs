namespace E_BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BombNums
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var index = (numbers.Count(x => x == bombs[0]));
            while (index != 0)
            {
                if (numbers.Contains(bombs[0]))
                {
                    var startPosition = (numbers.FindIndex(x => x == bombs[0])) - bombs[1];
                    var countPositions = (bombs[1] * 2) + 1;
                    if (startPosition < 0)
                    {
                        countPositions = countPositions - Math.Abs(startPosition);
                        startPosition = 0;
                    }

                    if ((numbers.FindIndex(x => x == bombs[0]) + bombs[1]) > numbers.Count - 1)
                    {
                        countPositions = (numbers.FindIndex(x => x == bombs[0]) + bombs[1]) - numbers.Count + 1;
                    }

                    numbers.RemoveRange(startPosition, countPositions);
                }

                index--;
            }

            var result = 0;
            for (int j = 0; j < numbers.Count; j++)
            {
                result += numbers[j];
            }

            Console.WriteLine(result);
        }
    }
}