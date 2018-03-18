namespace _2017._02_HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Armada
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var legions = new Dictionary<string, long>();
            var soldiers = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var lastActivity = int.Parse(input[0]);
                var legionName = input[1];
                var soldierType = input[2];
                var soldierCount = int.Parse(input[3]);

                if (!legions.ContainsKey(legionName))
                {
                    legions[legionName] = lastActivity;
                    soldiers[legionName] = new Dictionary<string, long>();
                }
                else if (lastActivity > legions[legionName])
                {
                    legions[legionName] = lastActivity;
                }

                if (!soldiers[legionName].ContainsKey(soldierType))
                {
                    soldiers[legionName][soldierType] = 0;
                }

                soldiers[legionName][soldierType] += soldierCount;
            }

            var command = Console.ReadLine();
            if (command.Contains("\\"))
            {
                var activity = int.Parse(command.Split('\\')[0]);
                var sType = command.Split('\\')[1];
                foreach (var soldier in soldiers.OrderByDescending(s => s.Value[sType]))
                {
                    var name = soldier.Key;
                    if (legions[name] < activity && soldiers[name].ContainsKey(sType))
                    {
                        Console.WriteLine($"{name} -> {soldiers[name][sType]}");
                    }
                }
            }
            else
            {
                foreach (var legion in legions.OrderByDescending(l => l.Value))
                {
                    var name = legion.Key;
                    if (soldiers[name].ContainsKey(command))
                    {
                        Console.WriteLine($"{legion.Value} : {name}");
                    }
                }
            }
        }
    }
}
