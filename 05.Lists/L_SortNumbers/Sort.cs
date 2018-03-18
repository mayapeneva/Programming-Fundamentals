namespace L_SortNumbers
{
    using System;
    using System.Linq;

    public class Sort
    {
        public static void Main()
        {
            var decimalNumbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            decimalNumbers.Sort();
            Console.WriteLine(string.Join(" <= ", decimalNumbers));
        }
    }
}