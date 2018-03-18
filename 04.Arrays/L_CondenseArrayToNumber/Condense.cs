namespace L_CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class Condense
    {
        public static void Main()
        {
            var numbers = string.Format(Console.ReadLine()).Split(' ').Select(int.Parse).ToArray();

            var condensed = new int[numbers.Length - 1];
            if (numbers.Length < 2)
            {
                Console.WriteLine(numbers[0]);
            }

            else
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = 0; j < condensed.Length; j++)
                    {
                        condensed[j] = numbers[j] + numbers[j + 1];
                        numbers[j] = condensed[j];
                    }
                }

                Console.WriteLine(condensed[0]);
            }
        }
    }
}