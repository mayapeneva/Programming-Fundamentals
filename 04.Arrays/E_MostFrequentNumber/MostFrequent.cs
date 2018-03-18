namespace E_MostFrequentNumber
{
    using System;
    using System.Linq;

    public class MostFrequent
    {
        public static void Main()
        {
            var arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var frequentNumber = 0;
            var frequentCounter = 1;
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                var currentNumber = arrayOfIntegers[i];
                var currentCounter = 1;
                for (int j = 0; j < arrayOfIntegers.Length; j++)
                {
                    if (arrayOfIntegers[i] == arrayOfIntegers[j])
                    {
                        currentCounter++;
                    }
                }

                if (currentCounter > frequentCounter)
                {
                    frequentCounter = currentCounter;
                    frequentNumber = currentNumber;
                }
            }

            Console.WriteLine(frequentNumber);
        }
    }
}