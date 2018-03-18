namespace L_CalculateTriangleArea
{
    using System;

    internal class TriangleArea
    {
        private static void Main()
        {
            var baseB = double.Parse(Console.ReadLine());
            var heightH = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfTriangle(baseB, heightH));
        }

        public static double AreaOfTriangle(double B, double H)
        {
            return (B * H) / 2;
        }
    }
}