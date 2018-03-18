namespace E_StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class GroupsOfStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var groups = new SortedDictionary<string, List<List<string>>>();
            var groupsCounter = 0;
            while (input != "End")
            {
                while (input.Contains("=>"))
                {
                    var townInput = input.Split(new[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    var townName = townInput[0];
                    var seats = townInput[1].Trim().Split();
                    var seatsNumber = int.Parse(seats[0]);
                    var town = new Town { SeatsCount = seatsNumber, Students = new List<Student>() };

                    input = Console.ReadLine();
                    while (input.Contains("|"))
                    {
                        var studentInput = input.Split('|');
                        var studentName = studentInput[0].Trim();
                        var studentEmail = studentInput[1].Trim();
                        var registrationDate = DateTime.ParseExact(studentInput[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                        var student = new Student { Name = studentName, Email = studentEmail, RegistrationDate = registrationDate };
                        town.Students.Add(student);

                        input = Console.ReadLine();
                    }

                    town.Students.OrderBy(a => a.RegistrationDate).ThenBy(a => a.Name).ThenBy(a => a.Email);

                    while (town.Students.Count > 0)
                    {
                        var students = new List<string>();
                        for (int j = 0; j < seatsNumber; j++)
                        {
                            if (town.Students.Count > 0)
                            {
                                students.Add(town.Students[0].Email);
                                town.Students.RemoveAt(0);
                            }
                            else
                            {
                                break;
                            }
                        }

                        groups[townName] = new List<List<string>>();
                        groups[townName].Add(students);
                        groupsCounter++;
                    }

                }
            }

            Console.WriteLine($"Created {groupsCounter} groups and {groups.Count} towns:");
            foreach (var town in groups)
            {
                foreach (var group in town.Value)
                {
                    foreach (var students in group)
                    {
                        Console.WriteLine($"{town.Key} => {string.Join(", ", students)}");
                    }
                }
            }
        }
    }
}
