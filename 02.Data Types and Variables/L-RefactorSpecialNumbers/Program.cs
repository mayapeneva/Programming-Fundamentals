using System;

namespace L_RefactorSpecialNumbers
{
    public class Program
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int digits = i;
                int sumOfDigits = 0;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                bool specialNumbers = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{i} -> {specialNumbers}");
            }
        }
    }
}