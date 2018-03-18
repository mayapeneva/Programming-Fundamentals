namespace E_MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;

    public class MagicWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstWord = input[0];
            var secondWord = input[1];

            var magicWords = true;
            var tempWords = new Dictionary<char, char>();
            for (int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
            {
                var firstSymbol = firstWord[i];
                var secondSymbol = secondWord[i];

                if (!tempWords.ContainsKey(firstSymbol) && !tempWords.ContainsValue(secondSymbol))
                {
                    tempWords[firstSymbol] = secondSymbol;
                }
                else if (!tempWords.ContainsKey(firstSymbol) && tempWords.ContainsValue(secondSymbol)
                    || tempWords[firstSymbol] != secondSymbol)
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            if (firstWord.Length > secondWord.Length)
            {
                magicWords = CheckTheLastPartForMagic(firstWord, secondWord.Length);
            }
            else if (firstWord.Length < secondWord.Length)
            {
                magicWords = CheckTheLastPartForMagic(secondWord, firstWord.Length);
            }

            Console.WriteLine(magicWords ? "true" : "false");
        }

        public static bool CheckTheLastPartForMagic(string words, int startIndex)
        {
            var magicWords = true;
            var tempWords = words.Substring(0, startIndex);
            for (int j = startIndex; j < words.Length; j++)
            {
                if (!tempWords.Contains(words[j].ToString()))
                {
                    magicWords = false;
                    break;
                }
            }
            return magicWords;
        }
    }
}