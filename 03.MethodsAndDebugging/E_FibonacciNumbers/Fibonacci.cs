namespace E_FibonacciNumbers
{
    using System;

    public class Fibonacci
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine(1);
            }

            else
            {
                var firstNumber = 1;
                var secondNumber = 1;
                var result = 2;
                for (int i = 0; i < n-2; i++)
                {
                    firstNumber = secondNumber;
                    secondNumber = result;
                    result = firstNumber + secondNumber;
                }

                Console.WriteLine(result);
            }
        }
    }
}
