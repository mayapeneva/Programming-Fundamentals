using System;

namespace L_Elevator
{
    public class Program
    {
        private static void Main()
        {
            var persons = double.Parse(Console.ReadLine());
            var capacity = double.Parse(Console.ReadLine());

            double courses = Math.Ceiling(persons / capacity);

            Console.WriteLine(courses);
        }
    }
}