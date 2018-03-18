namespace E_UnicodeCharacters
{
    using System;
    using System.Text;

    public class Unicode
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new StringBuilder();
            foreach (var symbol in input)
            {
                result.Append("\\u");
                result.AppendFormat("{0:x4}", (int)symbol);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
