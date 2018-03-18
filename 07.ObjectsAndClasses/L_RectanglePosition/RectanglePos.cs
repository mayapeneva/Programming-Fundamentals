namespace L_RectanglePosition
{
    using System;
    using System.Linq;

    public class RectanglePos
    {
        public static void Main()
        {
            var firstRectangleCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondRectangleCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var firstRectangle = new Rectangle
            {
                Left = firstRectangleCoordinates[0],
                Top = firstRectangleCoordinates[1],
                Width = firstRectangleCoordinates[2],
                Height = firstRectangleCoordinates[3]
            };

            var secondRectangle = new Rectangle
            {
                Left = secondRectangleCoordinates[0],
                Top = secondRectangleCoordinates[1],
                Width = secondRectangleCoordinates[2],
                Height = secondRectangleCoordinates[3]
            };

            if (FirstIsInSecond(firstRectangle, secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not Inside");
            }
        }

        public static bool FirstIsInSecond(Rectangle firstR, Rectangle secondR)
        {
            return (firstR.Top <= secondR.Top && firstR.Bottom >= secondR.Bottom 
                && firstR.Left >= secondR.Left && firstR.Right <= secondR.Right);
        }
    }
}
