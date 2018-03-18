using System;

namespace E_VowelOrDigit
{
    public class Program
    {
        private static void Main()
        {
            var symbol = char.Parse(Console.ReadLine());

            int unicode = Convert.ToInt16(symbol);
            if (unicode >= 48 && unicode <= 57)
            {
                Console.WriteLine("digit");
            }
            else if (unicode == 97 || unicode == 101 || unicode == 105 || unicode == 121 || unicode == 111 || unicode == 117)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}