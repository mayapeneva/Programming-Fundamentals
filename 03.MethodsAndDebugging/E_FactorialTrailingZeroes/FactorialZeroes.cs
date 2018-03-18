namespace E_FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class FactorialZeroes
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            GetFactorial(number);
        }

        public static void GetFactorial(int number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            GetTrailingZeroes(factorial);
        }

        public static void GetTrailingZeroes(BigInteger factorial)
        {
            var counter = 0;
            for (int i = 0; i < factorial.ToString().Length; i++)
            {
                if (factorial % 10 == 0)
                {
                    counter++;
                    factorial /= 10;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(counter);
        }
    }
}