namespace E_UseYourChainsBuddy
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Chains
    {
        public static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            var input = Console.ReadLine();
            var tags = new Regex(@"<p>(.*?)<\/p>");
            var matches = tags.Matches(input);
            foreach (Match match in matches)
            {
                var spaces = @"[^a-z0-9]+";
                var text = Regex.Replace(match.Groups[1].ToString(), spaces, " ").ToCharArray();
                var result = new StringBuilder();
                foreach (var symbol in text)
                {
                    if ((int)symbol == 32 | (int)symbol > 47 & (int)symbol < 58)
                    {
                        result.Append(symbol);
                    }
                    else if ((int)symbol < 110)
                    {
                        result.Append((char)((int)symbol + 13));
                    }
                    else
                    {
                        result.Append((char)((int)symbol - 13));
                    }
                }

                Console.Write(result.ToString());
            }

            Console.WriteLine();
        }
    }
}
