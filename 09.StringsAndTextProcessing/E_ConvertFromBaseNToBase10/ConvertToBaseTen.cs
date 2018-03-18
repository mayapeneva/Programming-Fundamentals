namespace E_ConvertFromBaseNToBase10
{
    using System;
    using System.Numerics;

    public class ConvertToBaseTen
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split();
            var n = int.Parse(numbers[0]);
            var numToConvert = BigInteger.Parse(numbers[1]);

            BigInteger result = 0;
            for (int i = 0; i < numbers[1].Length; i++)
            {
                result += (numToConvert % 10) * BigInteger.Pow(n, i);
                numToConvert /= 10;
            }

            Console.WriteLine(result);
        }
    }
}