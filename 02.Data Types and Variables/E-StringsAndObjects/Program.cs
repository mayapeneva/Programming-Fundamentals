using System;

namespace E_StringsAndObjects
{
    public class Program
    {
        private static void Main()
        {
            string firstVariable = "Hello";
            string secondVariable = "World";

            object thirdVariable = firstVariable + " " + secondVariable;
            string forthVariable = (string)thirdVariable;

            Console.WriteLine(forthVariable);
        }
    }
}