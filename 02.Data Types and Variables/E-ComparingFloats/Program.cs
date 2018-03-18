using System;

namespace E_ComparingFloats
{
    public class Program
    {
        private static void Main()
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());

            double difference = firstNumber - secondNumber;
            bool result = true;
            if (difference > 0.000001 || difference <= -0.000001)
            {
                result = false;
            }

            Console.WriteLine(result);
        }
    }
}