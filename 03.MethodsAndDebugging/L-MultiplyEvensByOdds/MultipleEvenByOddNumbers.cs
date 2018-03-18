namespace L_MultiplyEvensByOdds
{
    using System;

    internal class MultipleEvenByOddNumbers
    {
        private static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }

        public static int GetMultipleOfEvensAndOdds(int n)
        {
            var nPositive = Math.Abs(n);
            int sumEvens = 0;
            int sumOdds = 0;
            foreach (var symbol in nPositive.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == 0)
                {
                    sumEvens += digit;
                }
                else
                {
                    sumOdds += digit;
                }
            }
            return (sumEvens * sumOdds);
        }
    }
}