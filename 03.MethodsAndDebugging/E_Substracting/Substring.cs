namespace E_Substracting
{
    using System;

    public class Substring
    {
        public static void Main()
        {
            var text = string.Format(Console.ReadLine());
            var jump = int.Parse(Console.ReadLine());

            FindPAndCount(text, jump);
        }

        public static void FindPAndCount(string text, int jump)
        {
            bool hasMatch = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;
                    if (jump < text.Length - i)
                    {
                        Console.WriteLine(text.Substring(i, jump+1));
                        i += jump;
                    }

                    else
                    {
                        Console.WriteLine(text.Substring(i, (text.Length-i)));
                        break;
                    }
                }
            }

            if (hasMatch != true)
            {
                Console.WriteLine("no");
            }
        }
    }
}