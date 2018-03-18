namespace WormIpsum
{
    using System;
    using System.Linq;
    using System.Text;

    public class Ipsum
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "Worm Ipsum")
            {
                var sentences = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                var sentence = sentences[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (sentences.Length == 1 && (sentence[0][0] >= 65 && sentence[0][0] <= 90))
                {
                    for (int i = 0; i < sentence.Length; i++)
                    {
                        var word = sentence[i].ToCharArray();

                        var counter = 1;
                        var repeatingSymbol = default(char);
                        for (int j = 0; j < word.Length; j++)
                        {
                            var tempSymbol = word[j];
                            var tempCounter = word.Count(s => s == tempSymbol);
                            if (tempCounter > counter)
                            {
                                counter = tempCounter;
                                repeatingSymbol = tempSymbol;
                            }
                        }

                        if (counter >= 2)
                        {
                            var newWord = new StringBuilder();
                            for (int k = 0; k < word.Length; k++)
                            {
                                if (word[k] != ',')
                                {
                                    newWord.Append(repeatingSymbol);
                                }
                                else
                                {
                                    newWord.Append(word[k]);
                                }
                            }

                            sentence[i] = newWord.ToString();
                        }
                    }

                    Console.WriteLine($"{string.Join(" ", sentence)}.");
                }

                input = Console.ReadLine();
            }
        }
    }
}
