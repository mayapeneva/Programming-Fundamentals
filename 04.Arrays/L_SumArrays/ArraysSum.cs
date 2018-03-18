namespace L_SumArrays
{
    using System;
    using System.Linq;

    public class ArraysSum
    {
        public static void Main()
        {
            var firstNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            GetSummedNumbers(firstNumbers, secondNumbers);
        }

        public static void GetSummedNumbers(int[] firstArray, int[] secondArray)
        {
            var summedArray = new int[Math.Max(firstArray.Length, secondArray.Length)];
            for (int i = 0; i < summedArray.Length; i++)
            {
                summedArray[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
                Console.Write($"{summedArray[i]} ");
            }

            Console.WriteLine();
        }
    }
}