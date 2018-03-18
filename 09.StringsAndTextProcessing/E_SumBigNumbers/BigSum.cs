namespace E_SumBigNumbers
{
    using System;
    using System.Text;

    public class BigSum
    {
        public static void Main()
        {
            var firstBigNumber = new StringBuilder(Console.ReadLine());
            var secondBigNumber = new StringBuilder(Console.ReadLine());

            var lengthDifference = Math.Abs(firstBigNumber.Length - secondBigNumber.Length);
            string charsToAdd = new string('0', lengthDifference);
            if (firstBigNumber.Length > secondBigNumber.Length)
            {
                secondBigNumber.Insert(0, charsToAdd);
            }
            else if (firstBigNumber.Length < secondBigNumber.Length)
            {
                firstBigNumber.Insert(0, charsToAdd);
            }

            var result = new StringBuilder();
            result.Append(GetSum(firstBigNumber, secondBigNumber));

            Console.WriteLine(result.ToString().TrimStart('0'));
        }

        public static string GetSum(StringBuilder firstBigNumber, StringBuilder secondBigNumber)
        {
            var tempResult = new StringBuilder();
            var transferNum = 0;
            for (int i = firstBigNumber.Length - 1; i >= 0; i--)
            {
                var firstNum = firstBigNumber[i] - 48;
                var secondNum = secondBigNumber[i] - 48;
                var sum = firstNum + secondNum + transferNum;
                if (sum > 9)
                {
                    tempResult.Insert(0, (sum - 10).ToString());
                    transferNum = 1;
                }
                else
                {
                    tempResult.Insert(0, sum.ToString());
                    transferNum = 0;
                }
            }
            if (transferNum > 0)
            {
                tempResult.Insert(0, transferNum.ToString());
            }
            return tempResult.ToString();
        }
    }
}
