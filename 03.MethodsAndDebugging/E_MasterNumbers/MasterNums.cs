namespace E_MasterNumbers
{
    using System;

    public class MasterNums
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                var result = IfSymmetric(i);
                if (result)
                {
                    result = IfDigitsSumDivisibleBySeven(i);
                    if (result)
                    {
                        result = IfHoldsEvenDigit(i);
                        if (result)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }

        public static bool IfSymmetric(int n)
        {
            var result = true;
            var numberOfDigits = n.ToString().Length;
            var digits = n.ToString();
            var lastIndex = numberOfDigits - 1;
            for (int i = 0; i < numberOfDigits / 2; i++)
            {
                if (digits[i] == digits[lastIndex])
                {
                    lastIndex--;
                }
                else
                {
                    return false;
                }
            }

            return result;
        }

        public static bool IfDigitsSumDivisibleBySeven(int p)
        {
            var sum = 0;
            while (p > 0)
            {
                sum += p % 10;
                p /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IfHoldsEvenDigit(int q)
        {
            var result = false;
            var digits = q.ToString();
            for (int i = 0; i < q.ToString().Length; i++)
            {
                if (digits[i] % 2 == 0)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }

            return result;
        }
    }
}