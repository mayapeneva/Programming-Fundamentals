namespace E_TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TeamWork
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var teams = new Dictionary<string, Team>();
            for (int i = 0; i < n; i++)
            {
                var firstInput = Console.ReadLine().Split('-');
                var userName = firstInput[0];
                var teamName = firstInput[1];
                if (teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    if (teams.Values.Any(x => x.Creator == userName))
                    {
                        Console.WriteLine($"{userName} cannot create another team!");
                    }
                    else
                    {
                        teams[teamName] = new Team { Creator = userName, TeamMembers = new List<string>() };
                        Console.WriteLine($"Team {teamName} has been created by {userName}!");
                    }
                }

            }

            var secondInput = Console.ReadLine().Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            while (secondInput[0] != "end of assignment")
            {
                var userName = secondInput[0];
                var teamName = secondInput[1];
                if (!teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                {
                    if (teams.Values.Any(x => x.TeamMembers.Contains(userName)) || 
                        teams.Values.Any(y => y.Creator == userName))
                    {
                        Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    }
                    else
                    {
                        teams[teamName].TeamMembers.Add(userName);
                        teams[teamName].TeamMembers.Sort();
                    }
                }

                secondInput = Console.ReadLine().Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var disband = new List<string>();
            foreach (var team in teams.OrderByDescending(x => x.Value.TeamMembers.Count).ThenBy(y => y.Key))
            {
                if (team.Value.TeamMembers.Count > 0)
                {
                    Console.WriteLine(team.Key);
                    Console.WriteLine($"- {team.Value.Creator}");
                    foreach (var member in team.Value.TeamMembers)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
                else
                {
                    disband.Add(team.Key);
                }
            }

            Console.WriteLine("Teams to disband:");
            disband.Sort();
            foreach (var disbandTeam in disband)
            {
                Console.WriteLine(disbandTeam);
            }
        }
    }
}
