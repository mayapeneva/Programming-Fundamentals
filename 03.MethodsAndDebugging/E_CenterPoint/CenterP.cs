namespace E_CenterPoint
{
    using System;

    public class CenterP
    {
        public static void Main()
        {
            var firstX = double.Parse(Console.ReadLine());
            var firstY = double.Parse(Console.ReadLine());
            var secondX = double.Parse(Console.ReadLine());
            var secondY = double.Parse(Console.ReadLine());
            PrintClosestPoint(firstX, firstY, secondX, secondY);
        }

        public static void PrintClosestPoint(double firstX, double firstY, double secondX, double secondY)
        {
            var firstDiagonal = Math.Sqrt((firstX * firstX) + (firstY * firstY));
            var secondDiagonal = Math.Sqrt((secondX * secondX) + (secondY * secondY));
            if (firstDiagonal <= secondDiagonal)
            {
                Console.WriteLine($"({firstX}, {firstY})");
            }
            else
            {
                Console.WriteLine($"({secondX}, {secondY})");
            }
        }
    }
}