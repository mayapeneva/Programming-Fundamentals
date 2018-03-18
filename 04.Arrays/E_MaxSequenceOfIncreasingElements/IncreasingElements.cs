namespace E_MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class IncreasingElements
    {
        public static void Main()
        {
            var arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var sequenceLength = 1;
            var sequenceLongitude = new int[arrayOfIntegers.Length];
            sequenceLongitude[0] = 1;
            for (int i = 0; i < arrayOfIntegers.Length - 1; i++)
            {
                if (arrayOfIntegers[i + 1] > arrayOfIntegers[i])
                {
                    sequenceLength++;
                }
                else
                {
                    sequenceLength = 1;
                }
                sequenceLongitude[i + 1] = sequenceLength;
            }

            var maxLongitude = sequenceLongitude.Max();
            var sequenceStart = Array.IndexOf(sequenceLongitude, maxLongitude) - maxLongitude + 1;

            for (int j = sequenceStart; j < maxLongitude + sequenceStart; j++)
            {
                Console.Write($"{arrayOfIntegers[j]} ");
            }
            Console.WriteLine();
        }
    }
}