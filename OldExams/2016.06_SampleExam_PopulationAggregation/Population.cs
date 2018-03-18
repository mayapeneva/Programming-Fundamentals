namespace _2016._06_SampleExam_PopulationAggregation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Population
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('\\');

            var countries = new Dictionary<string, List<string>>();
            var towns = new Dictionary<string, long>();
            while (input[0] != "stop")
            {
                var tempCountry = new StringBuilder();
                var tempTown = new StringBuilder();
                var population = long.Parse(input[2]);

                var inputOne = input[0].ToCharArray();
                if (inputOne[0] > 64 && inputOne[0] < 91)
                {
                    GetLettersOnly(input[0], tempCountry);
                    GetLettersOnly(input[1], tempTown);
                }
                else
                {
                    GetLettersOnly(input[1], tempCountry);
                    GetLettersOnly(input[0], tempTown);
                }

                var country = tempCountry.ToString();
                var town = tempTown.ToString();
                if (!countries.ContainsKey(country))
                {
                    countries[country] = new List<string>();
                }

                countries[country].Add(town);

                if (!towns.ContainsKey(town))
                {
                    towns[town] = 0;
                }

                towns[town] = population;

                input = Console.ReadLine().Split('\\');
            }

            foreach (var kvp in countries.OrderBy(kvp => kvp.Key))
            {
               Console.WriteLine($"{kvp.Key} -> {kvp.Value.Count}");
            }

            var counter = 0;
            foreach (var kvp in towns.OrderByDescending(kvp => kvp.Value))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");

                counter++;
                if (counter == 3)
                {
                    break;
                }
            }
        }

        private static void GetLettersOnly(string input, StringBuilder countryOrTown)
        {
            var tempInput = input.ToCharArray();
            for (int i = 0; i < tempInput.Length; i++)
            {
                if ((tempInput[i] > 64 && tempInput[i] < 91)
                    || (tempInput[i] > 96 && tempInput[i] < 123))
                {
                    countryOrTown.Append(tempInput[i]);
                }
            }
        }
    }
}
