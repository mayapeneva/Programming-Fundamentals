namespace E_MentorGroup_WithClass
{
    using System;
    using System.Collections.Generic;

    public class Mentor
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var users = new SortedDictionary<string, Student>();

            while (input.ToString() != "end of dates")
            {
                var inputDates = input.Split();
                var user = inputDates[0];
                if (!users.ContainsKey(user))
                {
                    users[user] = new Student { Dates = new List<string>(), Comments = new List<string>()};
                }

                if (inputDates.Length > 1)
                {
                    var dates = inputDates[1].Split(',');
                    for (int i = 0; i < dates.Length; i++)
                    {
                        users[user].Dates.Add(dates[i]);
                    }
                }

                users[user].Dates.Sort();
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input.ToString() != "end of comments")
            {
                var inputComments = input.Split('-');
                var user = inputComments[0];
                if (users.ContainsKey(user))
                {
                    users[user].Comments.Add(inputComments[1]);
                }

                input = Console.ReadLine();
            }

            foreach (var student in users)
            {
                Console.WriteLine($"{student.Key}");
                Console.WriteLine("Comments:");

                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in student.Value.Dates)
                {
                    Console.WriteLine($"-- {date}");
                }
            }
        }
    }
}
