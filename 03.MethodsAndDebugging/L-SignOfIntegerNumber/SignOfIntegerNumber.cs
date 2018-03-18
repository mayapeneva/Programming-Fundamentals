namespace L_SignOfIntegerNumber
{
    using System;

    class SignOfIntegerNumber
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            IntegerSign(number);
        }

        public static void IntegerSign (int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }
    }
}
