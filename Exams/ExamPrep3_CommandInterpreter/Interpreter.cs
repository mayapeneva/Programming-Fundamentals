using System.Collections.Generic;

namespace ExamPrep3_CommandInterpreter
{
    using System;
    using System.Linq;

    public class Interpreter
    {
        public static void Main()
        {
            var collection = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                var ifParseSuccessful = false;
                uint start = 0;
                uint count = 0;
                if (command.Length == 5)
                {
                    ReverseOrSort(collection, command, out ifParseSuccessful, out start, count);
                }
                else
                {
                    RollLeftOrRight(collection, command, out ifParseSuccessful, out count);
                }

                if (!ifParseSuccessful)
                {
                    Console.WriteLine("Invalid input parameters.");
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine('[' + string.Join(", ", collection) + ']');
        }

        private static void ReverseOrSort(List<string> collection, string[] command, out bool ifParseSuccessful, out uint start, uint count)
        {
            ifParseSuccessful = uint.TryParse(command[2], out start);
            if (ifParseSuccessful && start < collection.Count)
            {
                ifParseSuccessful = uint.TryParse(command[4], out count);
                if (ifParseSuccessful && (count <= (collection.Count - start)))
                {
                    if (command[0] == "reverse")
                    {
                        collection.Reverse((int)start, (int)count);
                    }
                    else
                    {
                        collection.Sort((int)start, (int)count, StringComparer.InvariantCulture);
                    }
                }
            }
        }

        private static void RollLeftOrRight(List<string> collection, string[] command, out bool ifParseSuccessful, out uint count)
        {
            ifParseSuccessful = uint.TryParse(command[1], out count);
            if (ifParseSuccessful)
            {
                for (int i = 0; i < count % collection.Count; i++)
                {
                    if (command[0] == "rollLeft")
                    {
                        var stringToRoll = collection[0];
                        collection.RemoveAt(0);
                        collection.Add(stringToRoll);
                    }
                    else
                    {
                        var length = collection.Count - 1;
                        var stringToRoll = collection[length];
                        collection.RemoveAt(length);
                        collection.Insert(0, stringToRoll);
                    }
                }
            }
        }
    }
}