namespace E_PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Population
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('|').ToList();

            var cityPopulationresult = new Dictionary<string, Dictionary<string, int>>();
            var countryPopulationResult = new Dictionary<string, long>();
            while (input[0] != "report")
            {
                var city = input[0];
                var country = input[1];
                var population = int.Parse(input[2]);

                if (!cityPopulationresult.ContainsKey(country))
                {
                    cityPopulationresult[country] = new Dictionary<string, int>();
                    countryPopulationResult[country] = 0;
                }

                cityPopulationresult[country][city] = population;
                countryPopulationResult[country] += population;

                input = Console.ReadLine().Split('|').ToList();
            }

            foreach (var country in countryPopulationResult.OrderByDescending(key => key.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

                foreach (var city in cityPopulationresult[country.Key].OrderByDescending(key => key.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}