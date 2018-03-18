namespace E_CubeProperties
{
    using System;

    public class Cube
    {
        public static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine();

            Console.WriteLine("{0:f2}", CalculateCubeProperties(side, parameter));
        }

        public static double CalculateCubeProperties(double side, string parameter)
        {
            var result = 0.0;
            switch (parameter)
            {
                case "face": result = Math.Sqrt(2 * side * side); break;
                case "space": result = Math.Sqrt(3 * side * side); break;
                case "volume": result = (side*side*side); break;
                case "area": result = (6 * side * side); break;
            }
            return result;
        }
    }
}
