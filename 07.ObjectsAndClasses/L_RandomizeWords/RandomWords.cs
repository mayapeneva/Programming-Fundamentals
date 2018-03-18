namespace L_RandomizeWords
{
    using System;
    using System.Linq;

    public class RandomWords
    {
        public static void Main()
        {
            var wordsInput = Console.ReadLine().Split(' ').ToArray();

            var random = new Random();
            for (int i = 0; i < wordsInput.Length; i++)
            {
                var randomIndex = random.Next(0, wordsInput.Length);
                var currentWord = wordsInput[i];
                wordsInput[i] = wordsInput[randomIndex];
                wordsInput[randomIndex] = currentWord;
            }

            foreach (var word in wordsInput)
            {
                Console.WriteLine(word);
            }
        }
    }
}
