namespace E_PrimesChecker
{
    using System;

    public class PrimeCheck
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime((int)number));
        }

        public static bool IsPrime(int n)
        {
            bool result = true;
            if (n == 0 || n == 1 || n == 4)
            {
                return false;
            }

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}