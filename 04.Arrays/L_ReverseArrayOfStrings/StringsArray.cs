namespace L_ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    public class StringsArray
    {
        public static void Main()
        {
            var array = string.Format(Console.ReadLine());
            var strings = array.Split(' ').ToArray();

            for (int i = strings.Length - 1; i >= 0; i--)
            {
                Console.Write($"{strings[i]} ");
            }

            Console.WriteLine();
        }
    }
}
