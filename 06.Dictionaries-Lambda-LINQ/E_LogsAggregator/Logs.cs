namespace E_LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Logs
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var logSequence = Console.ReadLine().Split(' ').ToList();

            var result = new SortedDictionary<string, List <string>>();
            var durationResults = new SortedDictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                var ip = logSequence[0];
                var user = logSequence[1];
                var duration = int.Parse(logSequence[2]);
                if (!result.ContainsKey(user))
                {
                    result[user] = new List<string>();
                    durationResults[user] = 0;
                }

                if (!result[user].Contains(ip))
                {
                    result[user].Add(ip);
                }

                durationResults[user] += duration;

                logSequence = Console.ReadLine().Split(' ').ToList();
            }

            foreach (var name in result)
            {
                var time = durationResults[name.Key];
                var ipsList = name.Value;
                ipsList.Sort();
                Console.WriteLine($"{name.Key}: {time} [{string.Join(", ", ipsList)}]");
            }
        }
    }
}