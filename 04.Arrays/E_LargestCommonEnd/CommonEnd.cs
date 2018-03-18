namespace E_LargestCommonEnd
{
    using System;

    public class CommonEnd
    {
        public static void Main()
        {
            var firstString = string.Format(Console.ReadLine());
            var secondString = string.Format(Console.ReadLine());

            var firstArrayOfStrings = firstString.Split(' ');
            var secondArrayOfStrings = secondString.Split(' ');

            var beginningCounter = 0;
            var endCounter = 0;
            if (firstArrayOfStrings.Length > secondArrayOfStrings.Length)
            {
                beginningCounter = GetBeginningEnds(firstArrayOfStrings, secondArrayOfStrings);
                endCounter = GetEndEnds(firstArrayOfStrings, secondArrayOfStrings);
                GetResult(beginningCounter, endCounter);
            }
            else
            {
                beginningCounter = GetBeginningEnds(secondArrayOfStrings, firstArrayOfStrings);
                endCounter = GetEndEnds(secondArrayOfStrings, firstArrayOfStrings);
                GetResult(beginningCounter, endCounter);
            }
        }

        public static int GetBeginningEnds(string[] firstArray, string[] secondArray)
        {
            var counter = 0;
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }

        public static int GetEndEnds(string[] firstArray, string[] secondArray)
        {
            var counter = 0;
            var firstArrayIndex = firstArray.Length - 1;
            for (int i = secondArray.Length - 1; i >= 0; i--)
            {
                if (firstArray[firstArrayIndex] == secondArray[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
                firstArrayIndex--;
            }

            return counter;
        }

        public static void GetResult(int firstCounter, int secondCounter)
        {
            if (firstCounter == 0 && secondCounter == 0)
            {
                Console.WriteLine(0);
            }
            else if (firstCounter > secondCounter)
            {
                Console.WriteLine(firstCounter);
            }
            else
            {
                Console.WriteLine(secondCounter);
            }
        }
    }
}