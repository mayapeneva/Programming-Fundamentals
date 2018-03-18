namespace L_MinMaxSumAverage
{
    using System;
    using System.Linq;

    public class ShortWords
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', ';' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = text.Where(x => x.Length < 5).Distinct().OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}