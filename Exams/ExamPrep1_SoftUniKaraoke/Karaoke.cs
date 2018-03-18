namespace ExamPrep1_SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Karaoke
    {
        public static void Main()
        {
            var allParticipants = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var allSongs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var stagePerformance = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var result = new Dictionary<string, HashSet<string>>();
            while (stagePerformance[0] != "dawn")
            {
                var participant = stagePerformance[0];
                var song = stagePerformance[1];
                var award = stagePerformance[2];
                if (allParticipants.Contains(participant) && allSongs.Contains(song))
                {
                    if (!result.ContainsKey(participant))
                    {
                        result[participant] = new HashSet<string>();
                    }

                    result[participant].Add(award);
                }

                stagePerformance = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var singer in result.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");
                    foreach (var award in singer.Value.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
