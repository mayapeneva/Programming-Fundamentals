namespace OddLines
{
    using System.Collections.Generic;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            var file = File.ReadAllLines("../../text.txt");

            var oddLines = new List<string>();
            for (int i = 0; i < file.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLines.Add(file[i]);
                }
            }

            File.WriteAllLines("result.txt", oddLines);
            
        }
    }
}
