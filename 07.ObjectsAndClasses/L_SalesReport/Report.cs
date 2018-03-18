namespace L_SalesReport
{
    using System;
    using System.Collections.Generic;

    public class Report
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var towns = new SortedDictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                var listOfSales = Console.ReadLine().Split(' ');
                var sale = new Sale
                {
                    Town = listOfSales[0],
                    Product = listOfSales[1],
                    Price = decimal.Parse(listOfSales[2]),
                    Quantity = decimal.Parse(listOfSales[3])
                };

                if (!towns.ContainsKey(sale.Town))
                {
                    towns[sale.Town] = 0;
                }

                towns[sale.Town] += (sale.Price * sale.Quantity);
            }

            foreach (var town in towns)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:F2}");
            }
        }
    }
}
