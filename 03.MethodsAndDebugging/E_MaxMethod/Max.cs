namespace E_MaxMethod
{
    using System;

    public class Max
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());
            var firstMax = GetMax(firstNumber, secondNumber);
            Console.WriteLine(GetMax(firstMax, thirdNumber));
        }

        public static int GetMax(int numberOne, int numberTwo)
        {
            if (numberOne > numberTwo)
            {
                return numberOne;
            }

            return numberTwo;
        }
    }
}