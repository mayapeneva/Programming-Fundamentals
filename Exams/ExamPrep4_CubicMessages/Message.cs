namespace ExamPrep4_CubicMessages
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Message
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "Over!")
            {
                var m = int.Parse(Console.ReadLine());
                var regex = new Regex(@"(?<numberFirst>^[0-9]+)(?<message>[A-Za-z]+)(?<numberLast>[0-9]*)[^A-Za-z]*$");
                var IfMatchesFound = regex.IsMatch(input);

                if (IfMatchesFound)
                {
                    var messageMatch = regex.Match(input).Groups["message"].ToString().ToArray();
                    var numberFirst = regex.Match(input).Groups["numberFirst"].ToString().ToArray();
                    var numberLast = regex.Match(input).Groups["numberLast"].ToString().ToArray();

                    var verificationCode = new StringBuilder();
                    if (messageMatch.Length == m)
                    {
                        FormVerificationCode(m, verificationCode, messageMatch, numberFirst);
                        FormVerificationCode(m, verificationCode, messageMatch, numberLast);
                    }

                    if (verificationCode.Length != 0)
                    {
                        Console.WriteLine($"{string.Join("", messageMatch)} == {verificationCode}");
                    }
                }

                input = Console.ReadLine();
            }
        }

        private static void FormVerificationCode(int m, StringBuilder code, char[] message, char[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                var index = int.Parse(number[i].ToString());
                if (index >= 0 && index < m)
                {
                    code.Append(message[index]);
                }
                else
                {
                    code.Append(' ');
                }
            }
        }
    }
}
