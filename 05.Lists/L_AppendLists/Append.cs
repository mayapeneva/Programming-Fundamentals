namespace L_AppendLists
{
    using System;
    using System.Linq;

    public class Append
    {
        public static void Main()
        {
            var initialList = Console.ReadLine();

            var newlist = initialList.Trim().Split('|').ToList();
            for (int i = newlist.Count - 1; i >= 0; i--)
            {
                var currentList = newlist[i].Trim().Split(' ').ToList();
                if (currentList.Count != 0)
                {
                    Console.Write($"{string.Join(" ", currentList)} ");
                }
            }

            Console.WriteLine();
        }
    }
}