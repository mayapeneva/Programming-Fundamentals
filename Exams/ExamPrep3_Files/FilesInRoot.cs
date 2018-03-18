namespace ExamPrep3_Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class FilesInRoot
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var files = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < n; i++)
            {
                var filesInput = Console.ReadLine();

                var rootRegex = new Regex(@"^[^\\]+");
                var root = rootRegex.Match(filesInput).ToString();
                if (!files.ContainsKey(root))
                {
                    files[root] = new Dictionary<string, long>();
                }

                var fileNameRegex = new Regex(@"[^\\]+\.[a-z0-9]+;");
                var fileName = fileNameRegex.Match(filesInput).ToString().Trim(';');

                var sizeRegex = new Regex(@";[0-9]+");
                var size = long.Parse(sizeRegex.Match(filesInput).ToString().Trim(';'));

                if (files[root].ContainsKey(fileName))
                {
                    files[root][fileName] = size;
                }
                else
                {
                    files[root].Add(fileName, size);
                }
            }

            var query = Console.ReadLine().Split();
            var ifThereAreFiles = false;
            if (files.ContainsKey(query[2]))
            {
                foreach (var file in files[query[2]].OrderByDescending(f => f.Value).ThenBy(f => f.Key))
                {
                    if (file.Key.EndsWith(query[0]))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                        ifThereAreFiles = true;
                    }
                }
            }

            if (ifThereAreFiles == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}