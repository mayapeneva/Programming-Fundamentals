namespace E_IntersectionOfCircles
{
    using System;
    using System.Linq;

    public class Circles
    {
        public static void Main()
        {
            var inputOne = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var inputTwo = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var circleOne = new Circle { Center = new Point { X = inputOne[0], Y = inputOne[1] }, Radius = inputOne[2] };
            var circleTwo = new Circle { Center = new Point { X = inputTwo[0], Y = inputTwo[1] }, Radius = inputTwo[2] };

            Intersect(circleOne, circleTwo);
        }

        public static void Intersect(Circle circleOne, Circle circleTwo)
        {
            var distanceBetweenCenters = 
                Math.Sqrt(Math.Pow((circleTwo.Center.X - circleOne.Center.X), 2) 
                + Math.Pow((circleTwo.Center.Y - circleOne.Center.Y), 2));

            if (circleOne.Radius + circleTwo.Radius >= distanceBetweenCenters)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}