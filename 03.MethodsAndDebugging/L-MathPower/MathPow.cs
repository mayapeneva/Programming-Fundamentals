namespace L_MathPower
{
    using System;

    internal class MathPow
    {
        private static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var p = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(n, p));
        }

        public static double MathPower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}