namespace _2017._02_HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Comm
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var messages = new List<string>();
            var broadcasts = new List<string>();
            while (input != "Hornet is Green")
            {
                var msgRegex = new Regex(@"(?<recipient>[0-9]+)\s<->\s(?<message>[0-9(A-Za-z)?]+)$");
                var msg = msgRegex.Match(input);

                if (msg.Success)
                {
                    var recipient = string.Join("", msg.Groups["recipient"].Value.ToArray().Reverse());
                    var message = msg.Groups["message"].ToString();

                    messages.Add($"{recipient} -> {message}");
                }
                else
                {
                    var broadcastRegex = new Regex(@"(?<message>[^0-9]+)\s<->\s(?<frequency>[A-Za-z(0-9)?]+)$");
                    var broadcast = broadcastRegex.Match(input);

                    if (broadcast.Success)
                    {
                        var broadcastMessage = broadcast.Groups["message"].ToString();
                        var tempFrequency = broadcast.Groups["frequency"].Value.ToArray();
                        var frequency = new StringBuilder();
                        for (int i = 0; i < tempFrequency.Length; i++)
                        {
                            var symbol = tempFrequency[i];
                            if (char.IsUpper(symbol))
                            {
                                frequency.Append(symbol.ToString().ToLower());
                            }
                            else if (char.IsLower(symbol))
                            {
                                frequency.Append(symbol.ToString().ToUpper());
                            }
                            else
                            {
                                frequency.Append(symbol);
                            }
                        }

                        broadcasts.Add($"{frequency} -> {broadcastMessage}");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Any() ? string.Join(Environment.NewLine, broadcasts) : "None");

            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Any() ? string.Join(Environment.NewLine, messages) : "None");
        }
    }
}