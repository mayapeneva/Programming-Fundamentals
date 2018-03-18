namespace E_CharacterMultiplier
{
    using System;

    public class CharMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var firstString = input[0];
            var secondString = input[1];
            var sum = 0;

            if (firstString.Length > secondString.Length)
            {
                sum += FirstPartCharMultiplier(firstString, secondString, 0, secondString.Length);
                sum += SecondPartCharMultiplier(firstString, secondString.Length, firstString.Length);
            }
            else if (firstString.Length < secondString.Length)
            {
                sum += FirstPartCharMultiplier(firstString, secondString, 0, firstString.Length);
                sum += SecondPartCharMultiplier(secondString, firstString.Length, secondString.Length);
            }
            else
            {
                sum += FirstPartCharMultiplier(firstString, secondString, 0, secondString.Length);
            }

            Console.WriteLine(sum);
        }

        public static int FirstPartCharMultiplier(string firstString, string secondString, int firstIndex, int secondIndex)
        {
            var sum = 0;
            for (int i = firstIndex; i < secondIndex; i++)
            {
                sum += ((int)firstString[i] * (int)secondString[i]);
            }
            return sum;
        }

        public static int SecondPartCharMultiplier(string firstString, int firstIndex, int secondIndex)
        {
            var sum = 0;
            for (int i = firstIndex; i < secondIndex; i++)
            {
                sum += (int)firstString[i];
            }
            return sum;
        }
    }
}
