namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldedSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var k = numbers.Length / 4;

            var firstRowFirstPart = numbers
                .Take(k)
                .Reverse()
                .ToArray();
            var firstRowSecondPart = numbers
                .Reverse()
                .Take(k)
                .ToArray();
            var firstRow = firstRowFirstPart.Concat(firstRowSecondPart);

            var secondRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var result = firstRow
                .Zip(secondRow, (x, y) => x + y)
                .ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}