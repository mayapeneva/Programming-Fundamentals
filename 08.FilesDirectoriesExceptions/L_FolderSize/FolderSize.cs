namespace L_FolderSize
{
    using System.IO;
    using System.Linq;

    public class FolderSize
    {
        public static void Main()
        {
            var files = Directory
                .GetFiles("TestFolder")
                .Select(a => new FileInfo(a))
                .Sum(a => a.Length);

            var result = files / 1024.0 / 1024.0;
            File.WriteAllText("Megabytes.txt", result.ToString());
        }
    }
}
