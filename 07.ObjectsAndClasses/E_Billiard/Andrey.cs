namespace E_Billiard
{
    using System;
    using System.Collections.Generic;

    public class Andrey
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var shopList = new Dictionary<string, Entity>();
            for (int i = 0; i < n; i++)
            {
                var firstInput = Console.ReadLine().Split( new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                var entity = new Entity { Type = firstInput[0], Price = decimal.Parse(firstInput[1]) };

                if (!shopList.ContainsKey(entity.Type))
                {
                    shopList[entity.Type] = new Entity();
                }

                shopList[entity.Type] = entity;
            }

            var secondInput = Console.ReadLine().Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new SortedDictionary<string, Dictionary<string, int>>();
            while (secondInput[0] != "end of clients")
            {
                var drink = secondInput[1];
                var name = secondInput[0];
                var quantity = int.Parse(secondInput[2]);
                new Client() { Quantities = quantity, Entities = drink};
                if (shopList.ContainsKey(drink))
                {
                    if (!result.ContainsKey(name))
                    {
                        result[name] = new Dictionary<string, int>();
                    }

                    if (result[name].ContainsKey(drink))
                    {
                        result[name][drink] += quantity;
                    }
                    else
                    {
                        result[name][drink] = quantity;
                    }
                }

                secondInput = Console.ReadLine().Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            decimal totalBill = 0M;
            foreach (var client in result)
            {
                Console.WriteLine($"{client.Key}");
                var clientBill = 0M;
                foreach(var drink in client.Value)
                {
                    clientBill += (shopList[drink.Key].Price * drink.Value);
                    Console.WriteLine($"-- {drink.Key} - {drink.Value}");
                }
                Console.WriteLine($"Bill: {clientBill:F2}");
                totalBill += clientBill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
}