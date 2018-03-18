namespace L_ReverseArrayOfIntegers
{
    using System;

    public class IntegersArray
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();
        }
    }
}