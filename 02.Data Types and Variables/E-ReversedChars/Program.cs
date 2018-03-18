using System;

namespace E_ReversedChars
{
    public class Program
    {
        private static void Main()
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var thirdLetter = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdLetter}{secondLetter}{firstLetter}");
        }
    }
}