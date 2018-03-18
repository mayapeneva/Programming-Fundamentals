using System;

namespace L_Greeting
{
    public class Program
    {
        private static void Main()
        {
            var firstName = string.Format(Console.ReadLine());
            var lastName = string.Format(Console.ReadLine());
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}. You are {2} years old.", firstName, lastName, age);
        }
    }
}