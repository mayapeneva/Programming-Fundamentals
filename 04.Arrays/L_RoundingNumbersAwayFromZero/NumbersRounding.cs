namespace L_RoundingNumbersAwayFromZero
{
    using System;
    using System.Linq;

    public class NumbersRounding
    {
        public static void Main()
        {
            double[] numbers = ReadNumbers();
            int[] roundedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} -> {roundedNumbers[i]}");
            }
        }

        private static double[] ReadNumbers()
        {
            var text = string.Format(Console.ReadLine());
            var numbers = text.Split(' ').Select(double.Parse).ToArray();
            return numbers;
        }
    }
}
