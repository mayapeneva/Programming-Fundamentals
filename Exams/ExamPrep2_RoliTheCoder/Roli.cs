namespace ExamPrep2_RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Roli
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine();

            var result = new Dictionary<string, Event>();
            while (firstInput != "Time for Code")
            {
                if (firstInput.Contains('#'))
                {
                    var secondInput = firstInput.Split(new[] { '#', '@' }, StringSplitOptions.RemoveEmptyEntries);
                    var id = secondInput[0].Trim();
                    var eventName = secondInput[1].Trim();
                    if (!result.ContainsKey(id))
                    {
                        result[id] = new Event { Name = eventName, Participants = new SortedSet<string>() };
                        for (int i = 2; i < secondInput.Length; i++)
                        {
                            result[id].Participants.Add(secondInput[i].Trim());
                        }
                    }
                    else
                    {
                        if (result[id].Name == eventName)
                        {
                            for (int i = 2; i < secondInput.Length; i++)
                            {
                                result[id].Participants.Add(secondInput[i].Trim());
                            }
                        }
                    }
                }

                firstInput = Console.ReadLine();
            }

            foreach (var kvp in result.OrderByDescending(e => e.Value.Participants.Count).ThenBy(e => e.Value.Name))
            {
                Console.WriteLine($"{kvp.Value.Name} - {kvp.Value.Participants.Count}");
                foreach (var participant in kvp.Value.Participants)
                {
                    Console.WriteLine($"@{participant}");
                }
            }
        }
    }
}