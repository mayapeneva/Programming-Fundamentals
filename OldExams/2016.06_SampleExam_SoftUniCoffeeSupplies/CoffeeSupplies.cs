namespace _2016._06_SampleExam_SoftUniCoffeeSupplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CoffeeSupplies
    {
        public static void Main()
        {
            var delimiters = Console.ReadLine().Split();
            var info = Console.ReadLine();

            var coffee = new Dictionary<string, int>();
            var people = new Dictionary<string, string>();
            while (info != "end of info")
            {
                var infoParts = info.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                if (info.Contains(delimiters[0]))
                {
                    var name = infoParts[0];
                    var coffeeType = infoParts[1];
                    if (!people.ContainsKey(name))
                    {
                        people[name] = string.Empty;
                        if (!coffee.ContainsKey(coffeeType))
                        {
                            coffee[coffeeType] = 0;
                        }
                    }

                    people[name] = coffeeType;
                }
                else
                {
                    var coffeeTypes = infoParts[0];
                    var quantity = int.Parse(infoParts[1]);
                    if (!coffee.ContainsKey(coffeeTypes))
                    {
                        coffee[coffeeTypes] = 0;
                    }

                    coffee[coffeeTypes] += quantity;
                }

                info = Console.ReadLine();
            }

            foreach (var cofe in coffee.Where(c => c.Value == 0))
            {
                Console.WriteLine($"Out of {cofe.Key}");
            }

            var drinks = Console.ReadLine();
            while (drinks != "end of week")
            {
                var drinksParts = drinks.Split();
                var person = drinksParts[0];
                var coffeeQuantity = int.Parse(drinksParts[1]);

                var coffeeType = people[person];
                if (coffee.ContainsKey(coffeeType))
                {
                    coffee[coffeeType] -= coffeeQuantity;
                }

                if (coffee[coffeeType] <= 0)
                {
                    Console.WriteLine($"Out of {coffeeType}");
                }

                drinks = Console.ReadLine();
            }

            var coffeeLeftList = new List<string>();
            Console.WriteLine("Coffee Left:");
            foreach (var coffeeType in coffee.OrderByDescending(c => c.Value).Where(c => c.Value > 0))
            {
                Console.WriteLine($"{coffeeType.Key} {coffeeType.Value}");
                coffeeLeftList.Add(coffeeType.Key);
            }

            Console.WriteLine("For:");
            foreach (var person in people.OrderBy(p => p.Value).ThenByDescending(p => p.Key))
            {
                if (coffeeLeftList.Contains(person.Value))
                {
                    Console.WriteLine($"{person.Key} {person.Value}");
                }
            }
        }
    }
}
