namespace E_HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // The player's name can contain any ASCI symbol but ':'.
            var input = Console.ReadLine();
            var tempInput = input.Split(':');
            var player = tempInput[0];

            var playersCards = new Dictionary<string, List<string>>();
            while (player != "JOKER")
            {
                var cardsDrawn = input.Remove(0, player.Length).Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!playersCards.ContainsKey(player))
                {
                    playersCards[player] = new List<string>();
                }

                for (int i = 1; i < cardsDrawn.Length; i++)
                {
                    var card = cardsDrawn[i];
                    if (!playersCards[player].Contains(card))
                    {
                        playersCards[player].Add(card);
                    }
                }

                input = Console.ReadLine();
                tempInput = input.Split(':');
                player = tempInput[0];
            }

            foreach (var person in playersCards)
            {
                var sum = 0;

                foreach (var value in person.Value)
                {
                    if (value.Length == 2)
                    {
                        sum += GetSumOfValue(value[0], value[1]);
                    }
                    else
                    {
                        sum += GetSumOfValue(value[0], value[2]);
                    }
                }

                Console.WriteLine($"{person.Key}: {sum}");
            }
        }

        public static int GetSumOfValue(char firstValue, char secondValue)
        {
            var numberOne = 0;
            var numberTwo = 0;

            if (firstValue == 'J')
            {
                numberOne = 11;
            }
            else if (firstValue == 'Q')
            {
                numberOne = 12;
            }
            else if (firstValue == 'K')
            {
                numberOne = 13;
            }
            else if (firstValue == 'A')
            {
                numberOne = 14;
            }
            else if (firstValue == '1')
            {
                numberOne = 10;
            }
            else
            {
                numberOne = (int)firstValue - '0';
            }

            if (secondValue == 'S')
            {
                numberTwo = 4;
            }
            else if (secondValue == 'H')
            {
                numberTwo = 3;
            }
            else if (secondValue == 'D')
            {
                numberTwo = 2;
            }
            else
            {
                numberTwo = 1;
            }

            return (numberOne * numberTwo);
        }
    }
}