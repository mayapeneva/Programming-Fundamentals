namespace E_PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesInRange
    {
        public static void Main()
        {
            var startNumber = int.Parse(Console.ReadLine());
            var endNumber = int.Parse(Console.ReadLine());
            PrintAllPrimes(startNumber, endNumber);
        }

        public static void PrintAllPrimes(int startNumber, int endNumber)
        {
            var primesList = new List<int>();
            if (startNumber > 4)
            {
                Console.WriteLine(string.Join(", ", FindAllPrimes(startNumber, endNumber, primesList)));
            }
            else
            {
                primesList.Add(2);
                primesList.Add(3);
                startNumber = 5;
                Console.WriteLine(string.Join(", ", FindAllPrimes(startNumber, endNumber, primesList)));
            }
        }

        public static List<int> FindAllPrimes(int startNumber, int endNumber, List<int> primesList)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                bool result = true;
                for (int j = 2; j <= Math.Sqrt(endNumber); j++)
                {
                    if (i % j == 0)
                    {
                        result = false;
                        break;
                    }
                }

                if (result)
                {
                    primesList.Add(i);
                }
            }

            return primesList;
        }
    }
}