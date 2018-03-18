namespace E_ConvertFromBase10ToaseN
{
    using System;
    using System.Numerics;

    public class ConvertBases
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split();
            var n = int.Parse(numbers[0]);
            var numToConvert = BigInteger.Parse(numbers[1]);

            var result = string.Empty;
            while (numToConvert > 0)
            {
                var tempReminder = numToConvert / n;
                result = ((int)Math.Truncate((double)(numToConvert - tempReminder * n))) + result;
                numToConvert = tempReminder;
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}