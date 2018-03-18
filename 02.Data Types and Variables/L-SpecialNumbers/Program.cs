using System;

namespace L_SpecialNumbers
{
    public class Program
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int sumOfDigits = 0;
            for (int number = 1; number <= n; number++)
            {
                sumOfDigits = 0;
                int digits = number;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", number, special);
            }
        }
    }
}