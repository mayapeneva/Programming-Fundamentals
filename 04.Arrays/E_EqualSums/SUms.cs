namespace E_EqualSums
{
    using System;
    using System.Linq;

    public class Sums
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var numbersToCheckSums = new int[numbers.Length + 2];
            numbersToCheckSums[0] = numbersToCheckSums[numbers.Length + 1] = 0;
            for (int l = 1; l < numbers.Length + 1; l++)
            {
                numbersToCheckSums[l] = numbers[l - 1];
            }

            var IfEqualSums = false;
            for (int i = 1; i < numbers.Length + 1; i++)
            {
                var sumOne = 0;
                for (int j = 0; j < i; j++)
                {
                    sumOne += numbersToCheckSums[j];
                }

                var sumTwo = 0;
                for (int k = i + 1; k < numbers.Length + 2; k++)
                {
                    sumTwo += numbersToCheckSums[k];
                }

                if (sumOne == sumTwo)
                {
                    Console.WriteLine(i - 1);
                    IfEqualSums = true;
                }
            }

            if (IfEqualSums == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}