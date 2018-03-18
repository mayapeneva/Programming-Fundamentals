namespace E_MentorGroup
{
    using System;
    using System.Collections.Generic;

    public class MentorGroup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var usersByDates = new SortedDictionary<string, List<string>>();
            var usersByComments = new SortedDictionary<string, List<string>>();

            while (input.ToString() != "end of dates")
            {
                var inputDates = input.Split();
                var user = inputDates[0];
                if (!usersByDates.ContainsKey(user))
                {
                    usersByDates[user] = new List<string>();
                    usersByComments[user] = new List<string>();
                }

                if (inputDates.Length > 1)
                {
                    var dates = inputDates[1].Split(',');
                    for (int i = 0; i < dates.Length; i++)
                    {
                        usersByDates[user].Add(dates[i]);
                    }
                }

                usersByDates[user].Sort();
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input.ToString() != "end of comments")
            {
                var inputComments = input.Split('-');
                var user = inputComments[0];
                if (usersByComments.ContainsKey(user))
                {
                    usersByComments[user].Add(inputComments[1]);
                }

                input = Console.ReadLine();
            }

            foreach (var student in usersByDates)
            {
                Console.WriteLine($"{student.Key}");
                Console.WriteLine("Comments:");

                foreach (var comment in usersByComments[student.Key])
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                if (student.Value.Count > 0)
                {
                    foreach (var date in student.Value)
                    {
                        Console.WriteLine($"-- {date}");
                    }
                }
            }
        }
    }
}