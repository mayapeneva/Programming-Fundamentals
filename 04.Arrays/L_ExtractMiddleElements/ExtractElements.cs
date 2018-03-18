namespace L_ExtractMiddleElements
{
    using System;
    using System.Linq;

    public class ExtractElements
    {
        public static void Main()
        {
            var text = string.Format(Console.ReadLine());
            var numbers = text.Split(' ').Select(int.Parse).ToArray();
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else if (numbers.Length % 2 == 0)
            {
                Console.WriteLine($"{numbers[(numbers.Length / 2)-1]}, {numbers[numbers.Length / 2]}");
            }
            else
            {
                Console.WriteLine($"{numbers[(numbers.Length / 2)-1]}, {numbers[numbers.Length / 2]}, {numbers[(numbers.Length / 2) + 1]}");
            }
        }
    }
}
