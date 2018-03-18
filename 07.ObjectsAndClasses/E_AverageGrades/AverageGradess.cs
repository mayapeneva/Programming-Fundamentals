namespace E_AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGradess
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var name = input[0];

                var gradesList = new List<double>();
                for (int j = 1; j < input.Count; j++)
                {
                    gradesList.Add(double.Parse(input[j]));
                }

                var student = new Student
                {
                    Name = name,
                    Grades = gradesList
                };

                result.Add(student);
            }

            foreach (var student in result.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                if (student.AverageGrade >= 5.00)
                {
                    Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
                }
            }
        }
    }
}
