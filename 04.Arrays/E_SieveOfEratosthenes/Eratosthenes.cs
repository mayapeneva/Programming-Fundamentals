namespace E_SieveOfEratosthenes
{
    using System;

    public class Eratosthenes
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            if (n > 1)
            {
                var numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = i + 1;
                }

                var ifNotPrimes = GetPrimes(numbers);

                for (int j = 0; j < n; j++)
                {
                    if (ifNotPrimes[j] == false)
                    {
                        Console.Write($"{numbers[j]} ");
                    }
                }

                Console.WriteLine();
            }
        }

        private static bool[] GetPrimes(int[] numbers)
        {
            var ifNotPrimes = new bool[numbers.Length];
            ifNotPrimes[0] = true;

            for (int k = 1; k < numbers.Length; k++)
            {
                if (!ifNotPrimes[k])
                {
                    for (int l = 1; l <= Math.Sqrt(numbers.Length); l++)
                    {
                        if (numbers[l] <= Math.Sqrt(numbers[k]))
                        {
                            if (numbers[k] % numbers[l] == 0 && k != l)
                            {
                                ifNotPrimes[k] = true;
                                break;
                            }

                            ifNotPrimes[k] = false;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return ifNotPrimes;
        }
    }
}