namespace ExamPrep1_WinningTicket
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Ticket
    {
        public static void Main()
        {
            var allTickets = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var winningSymbols = new[] { "@", "#", "\\$", "\\^" };
            foreach (var item in allTickets)
            {
                var ticket = item.Trim();
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var leftPart = ticket.Remove(10, 10);
                    var rightPart = ticket.Remove(0, 10);
                    var ifTicketIsWinning = false;
                    var winningSymbol = string.Empty;
                    foreach (var symbol in winningSymbols)
                    {
                        var regex = new Regex($"{symbol}{{6}}");
                        var leftMatch = regex.Match(leftPart);
                        if (leftMatch.Success)
                        {
                            var rightMatch = regex.Match(rightPart);
                            if (rightMatch.Success)
                            {
                                ifTicketIsWinning = true;
                                winningSymbol = symbol.Trim('\\');
                                break;
                            }
                        }
                    }

                    if (ifTicketIsWinning)
                    {
                        var leftMatchLength = leftPart.LastIndexOf(winningSymbol) - leftPart.IndexOf(winningSymbol) + 1;
                        var rightMatchLength = rightPart.LastIndexOf(winningSymbol) - rightPart.IndexOf(winningSymbol) + 1;
                        var matchLength = Math.Min(leftMatchLength, rightMatchLength);
                        if (matchLength == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{winningSymbol} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{winningSymbol}");
                        }
                    }

                    if (!ifTicketIsWinning)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}