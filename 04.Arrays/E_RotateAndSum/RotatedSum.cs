namespace E_RotateAndSum
{
    using System;
    using System.Linq;

    public class RotatedSum
    {
        public static void Main()
        {
            var arrayOfInts = string.Format(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var numbers = arrayOfInts.Split(' ').Select(int.Parse).ToArray();
            var result = new int[numbers.Length];
            for (int i = 0; i < k; i++)
            {
                var temp = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    result[j] += numbers[j - 1];
                    numbers[j] = numbers[j - 1];
                }
                result[0] += temp;
                numbers[0] = temp;
            }

            Console.WriteLine(string.Join(" ", result).ToArray());
        }
    }
}
