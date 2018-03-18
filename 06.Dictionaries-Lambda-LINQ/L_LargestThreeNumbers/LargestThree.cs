namespace L_LargestThreeNumbers
{
    using System;
    using System.Linq;

    public class LargestThree
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = numbers.OrderByDescending(n => n).Take(3).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}