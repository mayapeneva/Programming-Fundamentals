namespace E_PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phone_Book
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
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}