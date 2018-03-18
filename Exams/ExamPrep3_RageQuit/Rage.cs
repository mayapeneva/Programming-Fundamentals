namespace ExamPrep3_RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Rage
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToUpper();

            var regex = new Regex(@"(?<string>[^0-9]+)(?<number>[0-9]+)");
            var matches = regex.Matches(input);

            var rageMessage = new List<string>();
            foreach (Match match in matches)
            {
                var stringToRepeat = match.Groups["string"];
                var repeatNumber = int.Parse(match.Groups["number"].ToString());

                for (int i = 0; i < repeatNumber; i++)
                {
                    rageMessage.Add(stringToRepeat.ToString());
                }
            }

            var uniqueSymbols = string.Join("", rageMessage).Distinct();
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count()}");
            Console.WriteLine(string.Join("", rageMessage));
        }
    }
}
