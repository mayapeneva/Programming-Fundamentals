namespace E_MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class EqualElements
    {
        public static void Main()
        {
            var arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var equalElement = 0;
            var sequenceLength = 1;
            var maxEqualElement = 0;
            var longestSequence = 1;
            for (int i = 0; i < arrayOfIntegers.Length-1; i++)
            {
                if (arrayOfIntegers[i] == arrayOfIntegers[i+1])
                {
                    sequenceLength++;
                    equalElement = arrayOfIntegers[i];
                    if (sequenceLength > longestSequence)
                    {
                        longestSequence = sequenceLength;
                        maxEqualElement = equalElement;
                    }
                }

                else
                {
                    sequenceLength = 1;
                }

            }

            for (int j = 0; j < longestSequence; j++)
            {
                Console.Write($"{maxEqualElement} ");
            }

            Console.WriteLine();
        }
    }
}