namespace L_MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class Names
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\b[A-Z][a-z+]+ [A-Z][a-z]+\b");
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
