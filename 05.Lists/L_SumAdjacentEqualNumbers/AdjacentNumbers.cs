namespace L_SumAdjacentEqualNumbers
{
    using System;
    using System.Linq;

    public class AdjacentNumbers
    {
        public static void Main()
        {
            var decimalList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            var currentNumber = decimalList[0];

            for (int i = 1; i < decimalList.Count; i++)
            {
                if (currentNumber == decimalList[i])
                {
                    currentNumber = decimalList[i] * 2;
                    decimalList[i - 1] = currentNumber;
                    decimalList.RemoveAt(i);
                    currentNumber = decimalList[0];
                    i = 0;
                }
                else
                {
                    currentNumber = decimalList[i];
                }
            }

            Console.WriteLine(string.Join(" ", decimalList));
        }
    }
}