namespace E_PhoneBookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhBUpgrade
    {
        public static void Main()
        {
            var command = Console.ReadLine().Split(' ').ToArray();

            var phoneBook = new Dictionary<string, string>();
            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "A":
                        if (!phoneBook.ContainsKey(command[1]))
                        {
                            phoneBook[command[1]] = string.Empty;
                        }

                        phoneBook[command[1]] = command[2];
                        break;

                    case "S":
                        if (phoneBook.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"{command[1]} -> {phoneBook[command[1]]}");
                        }

                        else
                        {
                            Console.WriteLine($"Contact {command[1]} does not exist.");
                        }
                        break;

                    case "ListAll":
                        var result = phoneBook.OrderBy(phone => phone.Key);
                        foreach (var phone in result)
                        {
                            Console.WriteLine($"{phone.Key} -> {phone.Value}");
                        }
                        break;
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}