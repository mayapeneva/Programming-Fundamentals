namespace E_UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Logs
    {
        public static void Main()
        {
            var command = Console.ReadLine().Split(' ', '=').ToArray();
            var ip = string.Empty;

            var result = new SortedDictionary<string, Dictionary <string, int>>();
            while (command[0] != "end")
            {
                ip = command[1];
                var user = command[5];

                if (!result.ContainsKey(user))
                {
                    result[user] = new Dictionary<string, int>();
                }

                if (!result[user].ContainsKey(ip))
                {
                    result[user][ip] = 0;
                }

                result[user][ip]++;

                command = Console.ReadLine().Split(' ', '=').ToArray();
            }

            foreach (var name in result)
            {
                Console.WriteLine($"{name.Key}: ");
                Console.Write($"{name.Value.First().Key} => {name.Value.First().Value}");

                foreach (var address in name.Value.Skip(1))
                {
                    Console.Write($", {address.Key} => {address.Value}");
                }

                Console.Write(".");
                Console.WriteLine();
            }
        }
    }
}