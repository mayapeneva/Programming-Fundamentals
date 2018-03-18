namespace L_OddOccurrences
{
    using System;
    using System.Collections.Generic;

    public class Odds
    {
        public static void Main()
        {
            var wordsSequence = Console.ReadLine().ToLower().Split(' ');

            var elements = new Dictionary<string, int>();
            foreach (var word in wordsSequence)
            {
                if (!elements.ContainsKey(word))
                {
                    elements[word] = 0;
                }

                elements[word]++;
            }

            var result = new List<string>();
            foreach (var element in elements)
            {
                if (element.Value % 2 != 0)
                {
                    result.Add(element.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}