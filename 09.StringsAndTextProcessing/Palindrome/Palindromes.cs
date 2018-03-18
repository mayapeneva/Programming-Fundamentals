namespace Palindrome
{
    using System;
    using System.Collections.Generic;

    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new SortedSet<string>();
            foreach (var word in text)
            {
                var palindrome = true;
                for (int i = 0; i < word.Length/2; i++)
                {
                    if (word[i] != word[word.Length-1-i])
                    {
                        palindrome = false;
                        break;
                    }
                }

                if (palindrome == true || word.Length == 1)
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}