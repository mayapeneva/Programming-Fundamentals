namespace L_ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Closest
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var pointsDict = new Dictionary<int, Point>();
            for (int i = 1; i <= n; i++)
            {
                var pointCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                var point = new Point() { X = pointCoordinates[0], Y = pointCoordinates[1] };
                pointsDict[i] = point;
            }

            var smallerDistance = double.MaxValue;
            var pointOne = new Point();
            var pointTwo = new Point();
            for (int j = 1; j <= n; j++)
            {
                for (int k = 1; k <= n && k != j; k++)
                {
                    var currentDistance = GetDistance(pointsDict[j], pointsDict[k]);
                    if (currentDistance < smallerDistance)
                    {
                        smallerDistance = currentDistance;
                        pointOne = pointsDict[k];
                        pointTwo = pointsDict[j];
                    }
                }
            }

            Console.WriteLine($"{smallerDistance:F3}");
            Console.WriteLine($"({pointOne.X}, {pointOne.Y})");
            Console.WriteLine($"({pointTwo.X}, {pointTwo.Y})");
        }


        public static double GetDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow((point1.X - point2.X), 2) + Math.Pow((point1.Y - point2.Y), 2));
        }
    }
}