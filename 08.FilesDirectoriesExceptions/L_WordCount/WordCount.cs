namespace L_WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        public static void Main()
        {
            var words = File.ReadAllText("../../words.txt")
                .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.ToLower())
                .ToArray();
            var text = File.ReadAllText("../../text.txt")
                .Split(new[] { ' ', '-', ',', '.', '\n', '\r', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.ToLower())
                .ToArray();

            var wordsCounter = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var counter = 0;
                for (int j = 0; j < text.Length; j++)
                {
                    if (currentWord == text[j])
                    {
                        counter++;
                    }
                }
                wordsCounter[currentWord] = counter;
            }

            var result = wordsCounter.OrderByDescending(x => x.Value).Select(x => $"{x.Key} - {x.Value}").ToArray();
            File.WriteAllLines("result.txt", result);
        }
    }
}
