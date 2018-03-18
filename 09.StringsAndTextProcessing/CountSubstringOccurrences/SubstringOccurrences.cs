namespace CountSubstringOccurrences
{
    using System;

    public class SubstringOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var substring = Console.ReadLine().ToLower();

            var counter = 0;
            var index = 0;
            while(true)
            {
                if (text.IndexOf(substring, index) >= 0)
                {
                    counter++;
                    index  = text.IndexOf(substring, index) + 1;
                }
                else
	            {
                    break;
                }
            }

            Console.WriteLine(counter);
        }
    }
}