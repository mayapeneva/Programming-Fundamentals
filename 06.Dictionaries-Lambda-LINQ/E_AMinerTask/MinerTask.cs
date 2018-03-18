namespace E_AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinerTask
    {
        public static void Main()
        {
            var sequence = Console.ReadLine();

            var result = new Dictionary<string, int>();
            while (sequence != "stop")
            {
                if (!result.ContainsKey(sequence))
                {
                    result[sequence] = 0;
                }

                var sequenceValue = int.Parse(Console.ReadLine());
                result[sequence] += sequenceValue;

                sequence = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}