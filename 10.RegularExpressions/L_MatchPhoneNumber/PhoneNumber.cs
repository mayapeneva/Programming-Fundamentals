namespace L_MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

    public class PhoneNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\+\d{3}( |-)\d\1\d{3}\1\d{4}\b");
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
