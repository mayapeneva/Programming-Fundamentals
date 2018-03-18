namespace E_SequenceOfCommands
{
    using System;
    using System.Linq;

    public class CommandsSequence
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            var command = Console.ReadLine().Split(' ').ToArray();

            while (!command[0].Equals("stop"))
            {
                if (command[0].Equals("add") ||
                    command[0].Equals("subtract") ||
                    command[0].Equals("multiply"))
                {
                    var firstArg = int.Parse(command[1]);
                    var secondArg = int.Parse(command[2]);

                    array = PerformAction(array, command[0], firstArg, secondArg);
                }

                else if (command[0].Equals("rshift"))
                {
                    array = ArrayShiftRight(array);
                }

                else if (command[0].Equals("lshift"))
                {
                    array = ArrayShiftLeft(array);
                }

                PrintArray(array);

                command = Console.ReadLine().Split(' ').ToArray();
            }
        }

        public static long[] PerformAction(long[] array, string action, int firstArg, int secondArg)
        {
            int pos = firstArg-1;
            int value = secondArg;

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
            }
            return array;
        }

        public static long[] ArrayShiftRight(long[] array)
        {
            var lastNumber = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastNumber;

            return array;
        }

        public static long[] ArrayShiftLeft(long[] array)
        {
            var firstNumber = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstNumber;

            return array;
        }

        public static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
