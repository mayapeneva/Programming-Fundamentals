namespace L_SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNums
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squares = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                var number = Math.Sqrt(numbers[i]);
                if (number == (int)number)
                {
                    squares.Add(numbers[i]);
                }
            }

            squares.Sort();
            squares.Reverse();
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
