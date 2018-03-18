namespace E_NumbersInReversedOrder
{
    using System;

    public class Reversed_Numbers
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
    }
}
