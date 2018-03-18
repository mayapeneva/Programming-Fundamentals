using System;

namespace E_Refactor_FastPrimeChecker
{
    public class Program
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                bool result = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        result = false;
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {result}");
            }
        }
    }
}