using System;

namespace E_EmployeeData
{
    public class Program
    {
        private static void Main()
        {
            var firstName = string.Format(Console.ReadLine());
            var lastName = string.Format(Console.ReadLine());
            var age = int.Parse(Console.ReadLine());
            var gender = char.Parse(Console.ReadLine());
            var personalID = long.Parse(Console.ReadLine());
            var employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");
        }
    }
}