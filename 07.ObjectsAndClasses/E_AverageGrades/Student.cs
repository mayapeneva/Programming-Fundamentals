﻿namespace E_AverageGrades
{
    using System.Collections.Generic;
    using System.Linq;

    class Student
    {
        public string Name { get; set; }

        public List <double> Grades { get; set; }

        public double AverageGrade => Grades.Average();
    }
}
