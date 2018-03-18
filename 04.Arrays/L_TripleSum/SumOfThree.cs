namespace L_TripleSum
{
    using System;
    using System.Linq;

    public class SumOfThree
    {
        public static void Main()
        {
            var array = Console.ReadLine();
            var numbers = array.Split(' ').Select(decimal.Parse).ToArray();

            var IfAnySum = false;
            for (int a = 0; a < numbers.Length-1; a++)
            {
                for (int b = 1; b < numbers.Length; b++)
                {
                    for (int c = 0; c < numbers.Length; c++)
                    {
                        if (a < b && numbers[c] == numbers[a] + numbers[b])
                        {
                            Console.WriteLine($"{numbers[a]} + {numbers[b]} == {numbers[c]}");
                            IfAnySum = true;
                            break;
                        }
                    }
                }
            }

            if (!IfAnySum)
            {
                Console.WriteLine("No");
            }
        }
    }
}