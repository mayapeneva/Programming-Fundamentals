using System;

namespace L_RefactorVolumeOfPyramid
{
    public class Program
    {
        private static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            var pyramidVolume = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", pyramidVolume);
        }
    }
}