namespace E_NumbersInReversedOrder
{
    using System;

    public class ReversedNumbers
    {
        public static void Main()
        {
            var number = decimal.Parse(Console.ReadLine());

            var stringOfNumber = number.ToString();
            for (int i = stringOfNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(stringOfNumber[i]);
            }

            Console.WriteLine();
        }

        public static void ReversePrintInteger(decimal number)
        {
            var digit = number % 10;
            do
            {
                Console.Write(digit);
                number = Math.Floor(number / 10);
                digit = number % 10;
            } while (digit > 0);

            Console.WriteLine();
        }

        public static void ReversePrintDecimal(decimal number)
        {
            var stringOfNumber = number.ToString();
            for (int i = stringOfNumber.Length-1; i >= 0; i--)
            {
                Console.Write(stringOfNumber[i]);
            }

            Console.WriteLine();
        }
    }
}
