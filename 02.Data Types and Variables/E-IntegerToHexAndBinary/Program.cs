using System;

namespace E_IntegerToHexAndBinary
{
    public class Program
    {
        private static void Main()
        {
            var decNumber = int.Parse(Console.ReadLine());

            string hexNumber = decNumber.ToString("X");
            string binNumber = Convert.ToString(decNumber, 2);

            Console.WriteLine(hexNumber);
            Console.WriteLine(binNumber);
        }
    }
}