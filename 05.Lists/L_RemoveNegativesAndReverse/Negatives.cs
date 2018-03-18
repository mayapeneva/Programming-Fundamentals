namespace L_RemoveNegativesAndReverse
{
    using System;
    using System.Linq;

    public class Negatives
    {
        public static void Main()
        {
            var negativesList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            negativesList.RemoveAll(x => x < 0);
            negativesList.Reverse();

            if (negativesList.Count != 0)
            {
                Console.WriteLine(string.Join(" ", negativesList));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}