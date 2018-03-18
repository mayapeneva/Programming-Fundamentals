namespace E_PairsByDIfference
{
    using System;
    using System.Linq;

    public class Pairs
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var difference = int.Parse(Console.ReadLine());

            var counter = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                for (int j = i+1; j < sequence.Length; j++)
                {
                    if (Math.Abs(sequence[i] - sequence[j]) == difference)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}