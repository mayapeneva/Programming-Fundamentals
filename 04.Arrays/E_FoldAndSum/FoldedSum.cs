namespace E_FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldedSUm
    {
        public static void Main()
        {
            var arrayOfInts = string.Format(Console.ReadLine());
            var numbers = arrayOfInts.Split(' ').Select(int.Parse).ToArray();

            var firstNewNumbers = new int[numbers.Length/2];
            var n = (numbers.Length / 4) - 1;
            for (int i = 0; i < numbers.Length/4; i++)
            {
                firstNewNumbers[i] = numbers[n];
                n--;
            }

            n = numbers.Length / 4;
            for (int l = numbers.Length-1; l >= (numbers.Length)*3/4; l--)
            {
                firstNewNumbers[n] = numbers[l];
                n++;
            }

            var secondNewNumbers = new int[numbers.Length / 2];
            n = 0;
            for (int j = numbers.Length/4; j < (numbers.Length*3)/4; j++)
            {
                secondNewNumbers[n] = numbers[j];
                n++;
            }

            var result = new int[numbers.Length/2];
            for (int k = 0; k < numbers.Length/2; k++)
            {
                result[k] = firstNewNumbers[k] + secondNewNumbers[k];
            }

            Console.WriteLine(string.Join(" ", result).ToArray());
        }
    }
}