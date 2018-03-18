namespace L_ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    public class Tag
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"<a.*?href=(""|')(.*?)\1>(.*?)<\/a>");
            while (input != "end")
            {
                var result = regex.Replace(input, @"[URL href=""$2""]$3[/URL]");
                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
