namespace E_MostFrequentNumber
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FrequentNumber
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("../../input.txt").Split().Select(int.Parse).ToArray();

            var mostFrequentNumber = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var currentCounter = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentCounter++;
                    }
                }

                if (mostFrequentNumber.Count == 0 || currentCounter >= mostFrequentNumber.Values.Max())
                {
                    mostFrequentNumber[numbers[i]] = currentCounter;
                }
            }

            var result = string.Empty;
            if (mostFrequentNumber.Keys.Count == 1)
            {
                result = $"The number {mostFrequentNumber.Keys} is the most frequent (occurs {mostFrequentNumber.Values} times)";
            }
            else
            {
                var frequentNumbers = new List<int>();
                foreach (var number in mostFrequentNumber)
                {
                    frequentNumbers.Add(number.Key);
                }
                result = $"The numbers {string.Join(", ", frequentNumbers)} have the same maximal frequence (each occurs {mostFrequentNumber.Values.Max()} times). The leftmost of them is {frequentNumbers[0]}.";
            }

            File.WriteAllText("result.txt", result);
        }
    }
}