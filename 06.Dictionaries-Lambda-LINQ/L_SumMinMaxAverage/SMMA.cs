namespace L_SumMinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SMMA
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var result = new Dictionary<string, double>();
            result["Sum"] = numbers.Sum();
            result["Min"] = numbers.Min();
            result["Max"] = numbers.Max();
            result["Average"] = numbers.Average();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}