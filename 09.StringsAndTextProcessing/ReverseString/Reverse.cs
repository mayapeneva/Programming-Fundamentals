namespace ReverseString
{
    using System;
    using System.Linq;

    public class Reverse
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var result = text.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}