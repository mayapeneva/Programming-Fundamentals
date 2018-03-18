using System;

namespace E_VariableInHexFormat
{
    public class Program
    {
        private static void Main()
        {
            var symbol = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(symbol, 16));
        }
    }
}