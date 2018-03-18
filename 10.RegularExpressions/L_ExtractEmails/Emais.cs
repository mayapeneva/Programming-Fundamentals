namespace L_ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class Emais
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\s[a-z0-9][a-z0-9\.\-_]+[a-z0-9]+@([\w\-]+\.)+\w+");
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
