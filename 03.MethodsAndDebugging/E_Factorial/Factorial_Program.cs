namespace E_Factorial
{
    using System;
    using System.Numerics;

    public class Factorial_Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            
            GetFactorial(number);
        }

        public static void GetFactorial(int number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}