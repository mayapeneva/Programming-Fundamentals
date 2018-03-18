namespace E_LettersChangeNumbers
{
    using System;
    using System.Linq;
    using System.Text;

    public class ChangeNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();

            var result = 0.0;
            foreach (var task in input)
            {
                var tempTask = new StringBuilder();
                var firstFactor = task[0];
                tempTask.Append(task.Remove(0, 1));
                var secondFactor = task[task.Length - 1];
                tempTask.Remove(tempTask.Length - 1, 1);
                var number = double.Parse(tempTask.ToString());

                var tempResult = 0.0;
                if ((int)firstFactor > 64 && (int)firstFactor < 91)
                {
                    tempResult = number / (firstFactor - 64);
                }
                else if ((int)firstFactor > 96 && (int)firstFactor < 123)
                {
                    tempResult = number * (firstFactor - 96);
                }

                if ((int)secondFactor > 64 && (int)secondFactor < 91)
                {
                    tempResult -= (secondFactor - 64);
                }
                else if ((int)secondFactor > 96 && (int)secondFactor < 123)
                {
                    tempResult += (secondFactor - 96);
                }

                result += tempResult;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
