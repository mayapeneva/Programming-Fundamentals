namespace L_CountNumbers
{
    using System;
    using System.Linq;

    public class Count
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();
            var previousNumber = numbers[0];
            var count = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == previousNumber)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{previousNumber} -> {count}");
                    count = 1;
                }

                previousNumber = numbers[i];
            }

            Console.WriteLine($"{previousNumber} -> {count}");
        }
    }
}