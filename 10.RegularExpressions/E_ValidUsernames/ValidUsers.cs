namespace E_ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ValidUsers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex(@"\b[A-Za-z]\w{2,24}$");
            var validUsers = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                var match = regex.IsMatch(input[i]);
                if (match == true)
                {
                    validUsers.Add(input[i]);
                }
            }

            var resultOne = string.Empty;
            var resultTwo = string.Empty;
            for (int j = 1; j < validUsers.Count; j++)
            {
                if ((validUsers[j - 1].Length + validUsers[j].Length) > (resultOne.Length + resultOne.Length))
                {
                    resultOne = validUsers[j - 1];
                    resultTwo = validUsers[j];
                }
            }

            Console.WriteLine(resultOne);
            Console.WriteLine(resultTwo);
        }
    }
}