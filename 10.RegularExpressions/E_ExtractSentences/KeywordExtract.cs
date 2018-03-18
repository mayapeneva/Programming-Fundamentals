namespace E_ExtractSentences
{
    using System;
    using System.Text.RegularExpressions;

    public class KeywordExtract
    {
        public static void Main()
        {
            var keyword = Console.ReadLine();
            var input = Console.ReadLine().Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex(@"\b" + keyword + @"\b");
            foreach (var sentence in input)
            {
                var matches = regex.IsMatch(sentence);
                if (matches == true)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
