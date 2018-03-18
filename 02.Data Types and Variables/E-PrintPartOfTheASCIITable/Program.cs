using System;

namespace E_PrintPartOfTheASCIITable
{
    public class Program
    {
        private static void Main()
        {
            var firstUnicode = int.Parse(Console.ReadLine());
            var lastUnicode = int.Parse(Console.ReadLine());

            for (int i = firstUnicode; i <= lastUnicode; i++)
            {
                char text = Convert.ToChar(i);
                Console.Write(text + " ");
            }
        }
    }
}