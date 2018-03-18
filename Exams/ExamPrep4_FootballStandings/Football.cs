namespace ExamPrep4_FootballStandings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Football
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();

            var results = new Dictionary<string, List<int>>();
            while (input != "final")
            {
                var teamRegex = new Regex(Regex.Escape(key) + @"(?<team>[A-Za-z]*)" + Regex.Escape(key));
                var teamMatches = teamRegex.Matches(input);

                var scoreRegex = new Regex(@"[0-9]+:[0-9]+");
                var scoreMatch = scoreRegex.Match(input).ToString().Split(':').Select(int.Parse).ToArray();

                var points = new int[2];
                if (scoreMatch[0] > scoreMatch[1])
                {
                    points[0] = 3;
                    points[1] = 0;
                }
                else if (scoreMatch[0] < scoreMatch[1])
                {
                    points[0] = 0;
                    points[1] = 3;
                }
                else
                {
                    points[0] = points[1] = 1;
                }

                var index = 0;
                foreach (Match teamMatch in teamMatches)
                {
                    var team = string.Join("", teamMatch.Groups["team"].ToString().ToUpper().Reverse().ToArray());

                    if (!results.ContainsKey(team))
                    {
                        results[team] = new List<int>();
                        results[team].Add(points[index]);
                        results[team].Add(scoreMatch[index]);
                    }
                    else
                    {
                        results[team][0] += points[index];
                        results[team][1] += scoreMatch[index];
                    }

                    index++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            var place = 1;
            foreach (var team in results.OrderByDescending(t => t.Value[0]).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{place}. {team.Key} {team.Value[0]}");
                place++;
            }

            Console.WriteLine("Top 3 scored goals:");
            place = 0;
            foreach (var team in results.OrderByDescending(t => t.Value[1]).ThenBy(t => t.Key))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value[1]}");
                place++;
                if (place == 3)
                {
                    break;
                }
            }
        }
    }
}