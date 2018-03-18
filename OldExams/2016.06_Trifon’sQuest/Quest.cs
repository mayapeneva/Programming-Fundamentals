namespace _2016._06_Trifon_sQuest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Quest
    {
        public static void Main()
        {
            long healthPoints = int.Parse(Console.ReadLine());
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long turns = 0;
            var currentRow = 0;
            var currentCol = 0;
            var quest = new List<List<char>>();
            for (int i = 0; i < dimensions[0]; i++)
            {
                quest.Add(Console.ReadLine().ToList());
            }

            for (int j = 1; j <= dimensions[1]; j++)
            {
                if (j % 2 != 0)
                {
                    for (int k = 1; k <= dimensions[0]; k++)
                    {
                        DealingWithObstacles(ref healthPoints, ref turns, quest, j, k, currentRow);
                        currentRow = k - 1;
                        if (healthPoints <= 0)
                        {
                            currentCol = j - 1;
                            break;
                        }
                    }
                }
                else
                {
                    for (int l = dimensions[0]; l > 0; l--)
                    {
                        DealingWithObstacles(ref healthPoints, ref turns, quest, j, l, currentRow);
                        currentRow = l - 1;
                        if (healthPoints <= 0)
                        {
                            currentCol = j - 1;
                            break;
                        }
                    }
                }
            }

            if (healthPoints > 0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine($"Health: {healthPoints}");
                Console.WriteLine($"Turns: {turns}");
            }
            else
            {
                Console.WriteLine($"Died at: [{currentRow}, {currentCol}]");
            }
        }

        private static void DealingWithObstacles(ref long healthPoints, ref long turns, List<List<char>> quest, int a, int b, int currentRow)
        {
            switch (quest[b - 1][a - 1])
            {
                case 'F': healthPoints -= turns / 2; break;
                case 'H': healthPoints += turns / 3; break;
                case 'T': turns += 2; break;
                case 'E': break;
            }
            turns++;
        }
    }
}
