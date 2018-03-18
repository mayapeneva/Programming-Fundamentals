namespace E_MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class MaxSequence
    {
        public static void Main()
        {
            var integerList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var currentElement = 0;
            var equalElement = 0;
            var currentCounter = 1;
            var maxCounter = 1;
            for (int i = 0; i < integerList.Count - 1; i++)
            {
                if (integerList[i] == integerList[i + 1])
                {
                    currentCounter++;
                    if (currentCounter > maxCounter)
                    {
                        maxCounter = currentCounter;
                        equalElement = integerList[i];
                    }
                }
                else
                {
                    currentCounter = 1;
                }
            }

            if (maxCounter > 1)
            {
                for (int k = 0; k < maxCounter; k++)
                {
                    Console.Write($"{equalElement} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}