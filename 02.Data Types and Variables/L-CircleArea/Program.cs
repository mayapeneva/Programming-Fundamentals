using System;

namespace L_CircleArea
{
    public class Program
    {
        private static void Main()
        {
            var r = double.Parse(Console.ReadLine());

            double area = 2 * r * r;

            Console.WriteLine("{f2:0}", area);
        }
    }
}