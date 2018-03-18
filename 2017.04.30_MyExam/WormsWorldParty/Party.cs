namespace WormsWorldParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Party
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

            var teams = new Dictionary<string, Team>();
            var worms = new Dictionary<string, Dictionary<string, int>>();
            while (input[0] != "quit")
            {
                var wormName = input[0];
                var teamName = input[1];
                var wormScore = int.Parse(input[2]);
                if (!worms.Values.Any(w => w.ContainsKey(wormName)))
                {
                    if (!teams.ContainsKey(teamName))
                    {
                        teams[teamName] = new Team();
                        worms[teamName] = new Dictionary<string, int>();
                    }

                    teams[teamName].TotalScore += wormScore;
                    worms[teamName].Add(wormName, wormScore);
                }

                input = Console.ReadLine().Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var team in teams)
            {
                team.Value.AverageScore = team.Value.TotalScore / worms[team.Key].Count();
            }

            var counter = 1;
            foreach (var team in teams.OrderByDescending(t => t.Value.TotalScore).ThenByDescending(t => t.Value.AverageScore))
            {
                Console.WriteLine($"{counter}. Team:{team.Key}- {team.Value.TotalScore}");
                
                foreach (var worm in worms[team.Key].OrderByDescending(w => w.Value))
                {
                    Console.WriteLine($"###{worm.Key}: {worm.Value}");
                }

                counter++;
            }
        }
    }
}
