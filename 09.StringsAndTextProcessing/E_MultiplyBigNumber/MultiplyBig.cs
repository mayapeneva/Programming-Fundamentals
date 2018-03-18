namespace E_MultiplyBigNumber
{
    using System;
    using System.Text;

    public class MultiplyBig
    {
        public static void Main()
        {
            var BigNumber = Console.ReadLine().TrimStart('0');
            var secondNumber = int.Parse(Console.ReadLine());

            int temp;
            if (int.TryParse(BigNumber, out temp) && temp == 0 || secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var result = new StringBuilder();
            var transferNum = 0;
            for (int i = BigNumber.Length - 1; i >= 0; i--)
            {
                double tempResult = ((BigNumber[i] - 48) * secondNumber) + transferNum;
                if (tempResult >= 10)
                {
                    var currentTransferNum = (int)Math.Truncate(tempResult / 10);
                    result.Insert(0, (tempResult - (currentTransferNum * 10)));
                    transferNum = currentTransferNum;
                }
                else
                {
                    result.Insert(0, tempResult);
                    transferNum = 0;
                }
            }

            if (transferNum > 0)
            {
                result.Insert(0, transferNum);
            }

            Console.WriteLine(result);
        }
    }
}
