namespace E_DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dragons
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var dragons = new Dictionary<string, SortedDictionary<string, List<double>>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                var color = input[0];
                var name = input[1];
                var damage = input[2] != "null" ? double.Parse(input[2]) : 45;
                var health = input[3] != "null" ? double.Parse(input[3]) : 250;
                var armor = input[4] != "null" ? double.Parse(input[4]) : 10;

                if (!dragons.ContainsKey(color))
                {
                    dragons[color] = new SortedDictionary<string, List<double>>();
                }

                dragons[color][name] = new List<double> { damage, health, armor };
            }

            var averageStats = new Dictionary<string, List<double>>();
            foreach (var type in dragons)
            {
                if (!averageStats.ContainsKey(type.Key))
                {
                    averageStats[type.Key] = new List<double>();
                }

                for (int j = 0; j < 3; j++)
                {
                    averageStats[type.Key].Add(FindAverageStatsPerType(type.Value, j));
                }

                Console.WriteLine($"{type.Key}::({averageStats[type.Key][0]:f2}/{averageStats[type.Key][1]:f2}/{averageStats[type.Key][2]:f2})");

                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }

        public static double FindAverageStatsPerType(SortedDictionary<string, List<double>> type, int index)
        {
            var tempList = new List<double>();
            foreach (var dragon in type)
            {
                tempList.Add(dragon.Value[index]);
            }

            var result = tempList.Average();
            return result;
        }
    }
}