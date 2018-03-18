namespace L_LastKNumbersSums
{
    using System;

    public class SumsKNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var numbers = new long[n];
            numbers[0] = 1;
            Console.Write($"{numbers[0]} ");
            for (int i = 1; i < n; i++)
            {
                int counter = 1;
                for (int j = i; j >= 1; j--)
                {
                    if (counter <= k)
                    {
                        numbers[i] += numbers[j - 1];
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();
        }
    }
}
