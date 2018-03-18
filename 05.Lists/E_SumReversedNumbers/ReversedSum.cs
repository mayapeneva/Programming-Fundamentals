namespace E_SumReversedNumbers
{
    using System;
    using System.Linq;

    public class ReversedSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToList();

            var sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                var reversedNumber = numbers[i].Reverse();
                sum += int.Parse(string.Join("", reversedNumber));
            }

            Console.WriteLine(sum);
        }
    }
}
