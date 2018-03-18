namespace E_IndexOfLetters
{
    using System;
    using System.Linq;

    public class Letters
    {
        public static void Main()
        {
            var word = Console.ReadLine().ToArray();

            string alpha = "abcdefghijklmnopqrstuvwxyz";
            char[] alphabet = (alpha + alpha.ToLower()).ToCharArray();
            
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {Array.IndexOf(alphabet, word[i])}");
            }
        }
    }
}