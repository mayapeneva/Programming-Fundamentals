namespace _2016._06_SampleExam_ArrayModifier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayModifier
    {
        public static void Main()
        {
            var integers = Console.ReadLine().Split().Select(long.Parse).ToList();

            var command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "swap":
                        SwapTheIntegers(integers, command);
                        break;
                    case "multiply":
                        MultiplyIntegers(integers, command);
                        break;
                    case "decrease":
                        for (int i = 0; i < integers.Count; i++)
                        {
                            integers[i]--;
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", integers));
        }

        private static void SwapTheIntegers(List<long> integers, string[] command)
        {
            var firstIndex = int.Parse(command[1]);
            var secondIndex = int.Parse(command[2]);
            var tempInteger = integers[firstIndex];
            integers[firstIndex] = integers[secondIndex];
            integers[secondIndex] = tempInteger;
        }

        private static void MultiplyIntegers(List<long> integers, string[] command)
        {
            var firstIndex = int.Parse(command[1]);
            var secondIndex = int.Parse(command[2]);
            long tempInteger = integers[firstIndex] * integers[secondIndex];
            integers[firstIndex] = tempInteger;
        }
    }
}
