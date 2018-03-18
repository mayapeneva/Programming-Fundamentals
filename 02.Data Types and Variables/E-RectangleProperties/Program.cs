using System;

namespace E_RectangleProperties
{
    public class Program
    {
        private static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (width + height);
            double area = (width * height);
            double diagonal = Math.Sqrt((width * width) + (height * height));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}