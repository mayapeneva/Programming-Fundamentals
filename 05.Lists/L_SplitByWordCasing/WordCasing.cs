namespace L_SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WordCasing
    {
        public static void Main()
        {
            var text = string.Format(Console.ReadLine()).Trim().Split(' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']').ToList();

            var lowerCaseList = new List<string>();
            var mixedCaseList = new List<string>();
            var upperCaseList = new List<string>();
            for (int i = 0; i < text.Count; i++)
            {
                var currentList = text[i];
                if (currentList != "")
                {
                    var lowerCaseLetters = currentList.Count(x => x >= 'a' && x <= 'z');
                    var upperCaseLetters = currentList.Count(x => x >= 'A' && x <= 'Z');
                    var symbols = currentList.Count(x => x >= ' ' && x < 'A');
                    if (lowerCaseLetters == 0 && upperCaseLetters != 0 && symbols == 0)
                    {
                        upperCaseList.Add(currentList);
                    }

                    else if (upperCaseLetters == 0 && lowerCaseLetters != 0 && symbols == 0)
                    {
                        lowerCaseList.Add(currentList);
                    }

                    else
                    {
                        mixedCaseList.Add(currentList);
                    }
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseList)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseList)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseList)}");
        }
    }
}