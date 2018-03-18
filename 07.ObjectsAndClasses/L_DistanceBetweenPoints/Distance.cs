namespace L_DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class Distance
    {
        public static void Main()
        {
            var pointOneCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var pointTwoCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var pointOne = new Point() { X = pointOneCoordinates[0], Y = pointOneCoordinates[1] };
            var pointTwo = new Point() { X = pointTwoCoordinates[0], Y = pointTwoCoordinates[1] };

            var result = GetDistance(pointOne.X, pointTwo.X, pointOne.Y, pointTwo.Y);
            Console.WriteLine($"{result:F3}");
        }

        public static double GetDistance(double X1, double X2, double Y1, double Y2)
        {
            return Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2));
        }
    }
}