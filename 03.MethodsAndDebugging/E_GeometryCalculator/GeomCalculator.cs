namespace E_GeometryCalculator
{
    using System;

    public class GeomCalculator
    {
        public static void Main()
        {
            var figureType = Console.ReadLine();
            Console.WriteLine("{0:f2}", CalculateArea(figureType));
        }

        private static double CalculateArea(string figureType)
        {
            var area = 0.0;
            switch (figureType)
            {
                case "triangle":
                    var triangleSide = double.Parse(Console.ReadLine());
                    var triangleHeight = double.Parse(Console.ReadLine());
                    area = (triangleSide * triangleHeight) / 2;
                    break;
                case "square": 
                    var squareSide = double.Parse(Console.ReadLine());
                    area = squareSide * squareSide;
                    break;
                case "rectangle":
                    var rectangleWidth = double.Parse(Console.ReadLine()); ;
                    var rectangleHeight = double.Parse(Console.ReadLine());
                    area = rectangleWidth * rectangleHeight;
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;
            }

            return area;
        }
    }
}
