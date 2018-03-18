namespace E_QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"[^&=?]*=[^&=]*");
            while (input != "END")
            {
                var result = new Dictionary<string, List<string>>();
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    var replacement = @"(?:%20|[\s\+\?]+)+";
                    var pairs = match.ToString().Split('=');
                    var field = Regex.Replace(pairs[0], replacement, " ").Trim();
                    var value = Regex.Replace(pairs[1], replacement, " ").Trim();
                    if (!result.ContainsKey(field))
                    {
                        result[field] = new List<string>();
                    }

                    result[field].Add(value);
                }

                foreach (var field in result)
                {
                    Console.Write($"{field.Key}=[{string.Join(", ", field.Value)}]");
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }


        }
    }
}