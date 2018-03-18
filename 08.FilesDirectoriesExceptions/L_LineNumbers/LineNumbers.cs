namespace L_LineNumbers
{
    using System.Collections.Generic;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            var text = File.ReadAllLines("../../text.txt");

            var linesList = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                linesList.Add($"{i+1}. {text[i]}");
            }

            File.WriteAllLines("result.txt", linesList);
        }
    }
}
