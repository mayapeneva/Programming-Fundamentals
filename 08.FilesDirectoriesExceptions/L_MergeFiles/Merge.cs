namespace L_MergeFiles
{
    using System.IO;

    public class Merge
    {
        public static void Main()
        {
            var firstText = File.ReadAllText("../../FileOne.txt").Split();
            var secondText = File.ReadAllText("../../FileTwo.txt").Split();

            for (int i = 0; i < firstText.Length; i++)
            {
                File.AppendAllText("result.txt", firstText[i] + "\r\n" + secondText[i]);
            }
        }
    }
}
