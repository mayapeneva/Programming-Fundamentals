namespace WormTest
{
    using System;

    public class Test
    {
        public static void Main()
        {
            var lengthInM = int.Parse(Console.ReadLine());
            var widthInCm = decimal.Parse(Console.ReadLine());

            var lengthInCm = lengthInM * 100;
            var reminder = 0M;
            if (widthInCm != 0)
            {
                reminder = lengthInCm % widthInCm;
            }

            var result = 0M;
            if (reminder == 0 || widthInCm == 0)
            {
                result = lengthInCm * widthInCm;
                Console.WriteLine($"{result:F2}");
            }
            else
            {
                result = (lengthInCm * 100) / widthInCm;
                Console.WriteLine($"{result:F2}%");
            }
        }
    }
}