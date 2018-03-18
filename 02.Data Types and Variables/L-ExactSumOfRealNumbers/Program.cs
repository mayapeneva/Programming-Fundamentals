using System;

namespace L_ExactSumOfRealNumbers
{
    public class Program
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                var number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}