namespace E_LongerLine
{
    using System;

    public class Lines
    {
        public static void Main()
        {
            var firstX = double.Parse(Console.ReadLine());
            var firstY = double.Parse(Console.ReadLine());
            var secondX = double.Parse(Console.ReadLine());
            var secondY = double.Parse(Console.ReadLine());
            var thirdX = double.Parse(Console.ReadLine());
            var thirdY = double.Parse(Console.ReadLine());
            var fourthX = double.Parse(Console.ReadLine());
            var fourthY = double.Parse(Console.ReadLine());

            var firstLineLength = FindLineLength(firstX, firstY, secondX, secondY);
            var secondLineLength = FindLineLength(thirdX, thirdY, fourthX, fourthY);
            if (firstLineLength >= secondLineLength)
            {
                PrintLongerLine(firstX, firstY, secondX, secondY);
            }
            else
            {
                PrintLongerLine(thirdX, thirdY, fourthX, fourthY);
            }
        }

        private static double FindLineLength(double X1, double Y1, double X2, double Y2)
        {
            return Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        }

        public static void PrintLongerLine(double X1, double Y1, double X2, double Y2)
        {
            var firstDiagonal = Math.Sqrt((X1 * X1) + (Y1 * Y1));
            var secondDiagonal = Math.Sqrt((X2 * X2) + (Y2 * Y2));
            if (firstDiagonal <= secondDiagonal)
            {
                Console.WriteLine($"({X1}, {Y1})({X2}, {Y2})");
            }

            else
            {
                Console.WriteLine($"({X2}, {Y2})({X1}, {Y1})");
            }
        }
    }
}